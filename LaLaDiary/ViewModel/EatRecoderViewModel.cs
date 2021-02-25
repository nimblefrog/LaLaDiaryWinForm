using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LaLaDiary.Model;

namespace LaLaDiary.ViewModel
{
    public class EatRecoderViewModel
    {
        public static List<EatRecoder> ViewModel { get; set; } 
        public static List<EatRecoder> GetEatRecoders()
        {
            var tempFoodDatas = FoodDataViewModel.GetFoodDatas();
            return new List<EatRecoder>
            {
                new EatRecoder
                {
                    Date = DateTime.Today,
                    EatFood = tempFoodDatas[0],
                    Qty = 1,
                    Note = "多喝水"
                },
                new EatRecoder
                {
                    Date = DateTime.Today,
                    EatFood = tempFoodDatas[1],
                    Qty = 2
                },
                new EatRecoder
                {
                    Date = DateTime.Today,
                    EatFood = tempFoodDatas[2],
                    Qty = 1.5
                }
            };
        }
    }
}
