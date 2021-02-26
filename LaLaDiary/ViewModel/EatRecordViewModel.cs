using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaLaDiary.Model;

namespace LaLaDiary.ViewModel
{
    public class EatRecordViewModel
    {
        public static Dictionary<DateTime, List<EatRecord>> ViewModel { get; set; } 
        public static List<EatRecord> GetEatRecoders()
        {
            var tempFoodDatas = FoodDataViewModel.GetFoodDatas();
            return new List<EatRecord>
            {
                new EatRecord
                {
                    Date = DateTime.Today,
                    EatFood = tempFoodDatas[0],
                    Qty = 1,
                    Note = "多喝水"
                },
                new EatRecord
                {
                    Date = DateTime.Today,
                    EatFood = tempFoodDatas[1],
                    Qty = 2
                },
                new EatRecord
                {
                    Date = DateTime.Today,
                    EatFood = tempFoodDatas[2],
                    Qty = 1.5
                }
            };
        }
    }
}
