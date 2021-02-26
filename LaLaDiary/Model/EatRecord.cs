using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaLaDiary.Model
{
    public class EatRecord
    {
        public DateTime Date { get; set; }
        public FoodData EatFood { get; set; }
        public double Qty { get; set; }
        public string Note { get; set; }

        public double TotalP
        {
            get { return EatFood.Protein*Qty; }
        }

        public double TotalF
        {
            get { return EatFood.Fat * Qty; }
        }

        public double TotalC
        {
            get { return EatFood.Carbohydrate * Qty; }
        }

        public double TotalCal
        {
            get { return EatFood.Calories * Qty; }
        }
    }
}
