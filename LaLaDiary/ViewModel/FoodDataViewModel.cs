using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaLaDiary.Model;

namespace LaLaDiary.ViewModel
{
    public class FoodDataViewModel
    {
        public static List<FoodData> ViewModel { get; set; } 
        public static List<FoodData> GetFoodDatas()
        {
            return new List<FoodData>
            {
                new FoodData
                {
                    Name = "雞腿",    
                    Protein = 10,
                    Fat = 4,
                    Carbohydrate = 5,
                    Calories = 100,
                    Type = FoodType.P,
                    Unit = "一隻"
                },
                new FoodData
                {
                    Name = "蘋果",    
                    Protein = 0,
                    Fat = 0,
                    Carbohydrate = 20,
                    Calories = 80,
                    Type = FoodType.C,
                    Unit = "100g"
                },
                new FoodData
                {
                    Name = "堅果",    
                    Protein = 0,
                    Fat = 10,
                    Carbohydrate = 3,
                    Calories = 105,
                    Type = FoodType.F,
                    Unit = "10g"
                }
            };
        }
    }
}
