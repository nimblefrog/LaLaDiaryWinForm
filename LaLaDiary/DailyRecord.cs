using System;
using System.Globalization;
using System.Windows.Forms;
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

        #endregion

        private readonly AutoCompleteStringCollection _itemNameCollection;

        public DailyRecord()
        {
            InitializeComponent();

            #region 列表資料呈現
            dgvRecord.Rows.Clear();
            var eatRecoders = EatRecoderViewModel.GetEatRecoders();
            
            double sumP = 0, sumF = 0, sumC = 0, sumCal = 0;
            foreach (var eatRecoder in eatRecoders)
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

            #endregion

            #region Food庫選單

            _itemNameCollection = new AutoCompleteStringCollection();
            var foodDatas = FoodDataViewModel.GetFoodDatas();
            foreach (var foodData in foodDatas)
            {
                _itemNameCollection.Add(foodData.Name);
            }

            #endregion
        }

        private void btBasicInfo_Click(object sender, EventArgs e)
        {
            var basicInfoWindow = new BasicInformation();
            basicInfoWindow.Show();
        }

        private void btFoodDb_Click(object sender, EventArgs e)
        {
            var foodDbWindow = new FoodDatabase();
            foodDbWindow.Show();
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
                        //dgvRecord.Rows[rowIndex].Cells[_unitP].Value = 
                    };
                }
            }
        }
    }
}
