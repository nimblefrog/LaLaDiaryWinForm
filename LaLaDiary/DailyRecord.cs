using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LaLaDiary.Model;
using LaLaDiary.ViewModel;

namespace LaLaDiary
{
    public partial class DailyRecord : Form
    {
        #region DataGridView column name

        private const string _itemName = "ItemName";
        private const string _unitP = "UnitP";
        private const string _unitF = "UnitF";
        private const string _unitC = "UnitC";
        private const string _unitCal = "UnitCal";
        private const string _qty = "Qty";
        private const string _totalP = "TotalP";
        private const string _totalF = "TotalF";
        private const string _totalC = "TotalC";
        private const string _totalCal = "TotalCal";
        private const string _note = "Note";

        #endregion

        private readonly AutoCompleteStringCollection _itemNameCollection;

        public DailyRecord()
        {
            InitializeComponent();

            FoodDataViewModel.ViewModel = FoodDataViewModel.GetFoodDatas();
            EatRecoderViewModel.ViewModel = EatRecoderViewModel.GetEatRecoders();
            BasicInfoViewModel.ViewModel = new BasicInfo();

            #region 列表資料呈現

            dgvRecord.Rows.Clear();
            
            double sumP = 0, sumF = 0, sumC = 0, sumCal = 0;
            foreach (var eatRecoder in EatRecoderViewModel.ViewModel)
            {
                var index = dgvRecord.Rows.Add();
                dgvRecord.Rows[index].Cells[_itemName].Value = eatRecoder.EatFood.Name;
                dgvRecord.Rows[index].Cells[_unitP].Value = eatRecoder.EatFood.Protein;
                dgvRecord.Rows[index].Cells[_unitF].Value = eatRecoder.EatFood.Fat;
                dgvRecord.Rows[index].Cells[_unitC].Value = eatRecoder.EatFood.Carbohydrate;
                dgvRecord.Rows[index].Cells[_unitCal].Value = eatRecoder.EatFood.Calories;
                dgvRecord.Rows[index].Cells[_qty].Value = eatRecoder.Qty;
                dgvRecord.Rows[index].Cells[_totalP].Value = eatRecoder.TotalP;
                dgvRecord.Rows[index].Cells[_totalF].Value = eatRecoder.TotalF;
                dgvRecord.Rows[index].Cells[_totalC].Value = eatRecoder.TotalC;
                dgvRecord.Rows[index].Cells[_totalCal].Value = eatRecoder.TotalCal;
                dgvRecord.Rows[index].Cells[_note].Value = eatRecoder.Note;

                sumP += eatRecoder.TotalP;
                sumF += eatRecoder.TotalF;
                sumC += eatRecoder.TotalC;
                sumCal += eatRecoder.TotalCal;                
            }
            #endregion

            #region 統計表

            lbTodayP.Text = sumP.ToString(CultureInfo.InvariantCulture);
            lbTodayF.Text = sumF.ToString(CultureInfo.InvariantCulture);
            lbTodayC.Text = sumC.ToString(CultureInfo.InvariantCulture);
            lbTodayCal.Text = sumCal.ToString(CultureInfo.InvariantCulture);

            UpdateTargetBasicInfo();

            lbSurplusP.Text = (BasicInfoViewModel.ViewModel.TargetP - sumP).ToString();
            lbSurplusF.Text = (BasicInfoViewModel.ViewModel.TargetF - sumF).ToString();
            lbSurplusC.Text = (BasicInfoViewModel.ViewModel.TargetC - sumC).ToString();
            lbSurplusCal.Text = (BasicInfoViewModel.ViewModel.TargetCal - sumCal).ToString();

            #endregion

            #region Food庫選單

            _itemNameCollection = new AutoCompleteStringCollection();
            foreach (var foodData in FoodDataViewModel.ViewModel)
            {
                _itemNameCollection.Add(foodData.Name);
            }

            #endregion
        }

        private void UpdateTargetBasicInfo()
        {
            lbTargetP.Text = BasicInfoViewModel.ViewModel.TargetP.ToString();
            lbTargetF.Text = BasicInfoViewModel.ViewModel.TargetF.ToString();
            lbTargetC.Text = BasicInfoViewModel.ViewModel.TargetC.ToString();
            lbTargetCal.Text = BasicInfoViewModel.ViewModel.TargetCal.ToString();
        }

        private void btBasicInfo_Click(object sender, EventArgs e)
        {
            var basicInfoWindow = new BasicInformation();
            basicInfoWindow.ShowDialog();

            //更新目標
            UpdateTargetBasicInfo();
        }

        private void btFoodDb_Click(object sender, EventArgs e)
        {
            var foodDbWindow = new FoodDatabase();
            foodDbWindow.ShowDialog();
            //更新food庫
            _itemNameCollection.Clear();
            foreach (var foodData in FoodDataViewModel.ViewModel)
            {
                _itemNameCollection.Add(foodData.Name);
            }
        }

        private void dgvRecord_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = dgvRecord.Columns[dgvRecord.CurrentCell.ColumnIndex].Name;
            if (colName == _itemName)
            {
                var txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource = _itemNameCollection;
                    txt.Leave += (o, args) =>
                    {
                        var rowIndex = dgvRecord.CurrentCell.RowIndex;
                        var itemName = txt.Text;
                        var foodData = FoodDataViewModel.ViewModel.FirstOrDefault(x => x.Name == itemName);
                        if (foodData != null)
                        {
                            dgvRecord.Rows[rowIndex].Cells[_unitP].Value = foodData.Protein;
                            dgvRecord.Rows[rowIndex].Cells[_unitF].Value = foodData.Fat;
                            dgvRecord.Rows[rowIndex].Cells[_unitC].Value = foodData.Carbohydrate;
                            dgvRecord.Rows[rowIndex].Cells[_unitCal].Value = foodData.Calories;
                        }
                    };
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EatRecoderViewModel.ViewModel.Clear();
            foreach (DataGridViewRow row in dgvRecord.Rows)
            {
                if(row.Cells[_itemName].Value == null) continue;
                var itemName = row.Cells[_itemName].Value.ToString();
                var foodData = FoodDataViewModel.ViewModel.FirstOrDefault(x => x.Name == itemName);
                if (foodData == null)
                {
                    foodData = new FoodData
                    {
                        Name = itemName,
                        Protein = Convert.ToInt32(row.Cells[_unitP].Value),
                        Fat = Convert.ToInt32(row.Cells[_unitF].Value),
                        Carbohydrate = Convert.ToInt32(row.Cells[_unitC].Value),
                        Calories = Convert.ToInt32(row.Cells[_unitCal].Value)
                    };
                    FoodDataViewModel.ViewModel.Add(foodData);
                }
                var eatRecoder = new EatRecoder
                {
                    EatFood = foodData,
                    Qty = Convert.ToDouble(row.Cells[_qty].Value),
                    Note = row.Cells[_note].ToString(),
                    Date = dateTimePicker1.Value
                };

                EatRecoderViewModel.ViewModel.Add(eatRecoder);
            }
        }

        private void dgvRecord_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //更新統計數據
            double sumP = 0, sumF = 0, sumC = 0, sumCal = 0;
            foreach (DataGridViewRow row in dgvRecord.Rows)
            {
                if (row.Cells[_qty].ToString() == "") continue;
                var qty = Convert.ToDouble(row.Cells[_qty].Value);
                //P
                var tempValue = Convert.ToInt32(row.Cells[_unitP].Value) * qty;
                row.Cells[_totalP].Value = tempValue;
                sumP += tempValue;
                //F
                tempValue = Convert.ToInt32(row.Cells[_unitF].Value) * qty;
                row.Cells[_totalF].Value = tempValue;
                sumF += tempValue;
                //C
                tempValue = Convert.ToInt32(row.Cells[_unitC].Value) * qty;
                row.Cells[_totalC].Value = tempValue;
                sumC += tempValue;
                //Cal
                tempValue = Convert.ToInt32(row.Cells[_unitCal].Value) * qty;
                row.Cells[_totalCal].Value = tempValue;
                sumCal += tempValue;
            }

            lbTodayP.Text = sumP.ToString(CultureInfo.InvariantCulture);
            lbTodayF.Text = sumF.ToString(CultureInfo.InvariantCulture);
            lbTodayC.Text = sumC.ToString(CultureInfo.InvariantCulture);
            lbTodayCal.Text = sumCal.ToString(CultureInfo.InvariantCulture);

            lbSurplusP.Text = (BasicInfoViewModel.ViewModel.TargetP - sumP).ToString();
            lbSurplusF.Text = (BasicInfoViewModel.ViewModel.TargetF - sumF).ToString();
            lbSurplusC.Text = (BasicInfoViewModel.ViewModel.TargetC - sumC).ToString();
            lbSurplusCal.Text = (BasicInfoViewModel.ViewModel.TargetCal - sumCal).ToString();
        }
    }
}
