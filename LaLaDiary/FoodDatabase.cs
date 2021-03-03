using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LaLaDiary.Model;
using LaLaDiary.ViewModel;

namespace LaLaDiary
{
    public partial class FoodDatabase : Form
    {

        #region DataGridView column name

        private const string _itemName = "ItemName";
        private const string _unitP = "UnitP";
        private const string _unitF = "UnitF";
        private const string _unitC = "UnitC";
        private const string _unitCal = "UnitCal";
        private const string _unit = "Unit";

        #endregion


        public FoodDatabase()
        {
            InitializeComponent();

            DisplayDgvFoodDb(FoodDataViewModel.ViewModel);
        }

        private void DisplayDgvFoodDb(List<FoodData> foodDatas)
        {
            dgvFoodDb.Rows.Clear();
            foreach (var foodData in foodDatas)
            {
                var index = dgvFoodDb.Rows.Add();
                dgvFoodDb.Rows[index].Cells[_itemName].Value = foodData.Name;
                dgvFoodDb.Rows[index].Cells[_unitP].Value = foodData.Protein;
                dgvFoodDb.Rows[index].Cells[_unitF].Value = foodData.Fat;
                dgvFoodDb.Rows[index].Cells[_unitC].Value = foodData.Carbohydrate;
                dgvFoodDb.Rows[index].Cells[_unitCal].Value = foodData.Calories;
                dgvFoodDb.Rows[index].Cells[_unit].Value = foodData.Unit;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FoodDataViewModel.ViewModel.Clear();
            foreach (DataGridViewRow row in dgvFoodDb.Rows)
            {
                if(row.Cells[_itemName].Value == null) continue;
                var foodData = new FoodData
                {
                    Name = row.Cells[_itemName].Value.ToString(),
                    Protein = Convert.ToInt32(row.Cells[_unitP].Value),
                    Fat = Convert.ToInt32(row.Cells[_unitF].Value),
                    Carbohydrate = Convert.ToInt32(row.Cells[_unitC].Value),
                    Calories = Convert.ToInt32(row.Cells[_unitCal].Value),
                    Unit = row.Cells[_unit].Value.ToString()
                };

                FoodDataViewModel.ViewModel.Add(foodData);
            }

            DisplayDgvFoodDb(FoodDataViewModel.ViewModel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
