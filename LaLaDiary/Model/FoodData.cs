using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaLaDiary.Model
{
    public class FoodData
    {
        public string Name { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Carbohydrate { get; set; }
        public int Calories { get; set; }
        public FoodType Type { get; set; }
        public string Unit { get; set; }
    }

    public enum FoodType
    {
        None = 0,
        P = 1,
        F = 2,
        C = 3
    }
}
