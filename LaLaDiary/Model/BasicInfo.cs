using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaLaDiary.Model
{
    public class BasicInfo
    {
        public float CurrentWeight { get; set; }
        public float TargetWeight { get; set; }
        public int TargetP { get; set; }
        public int TargetF { get; set; }
        public int TargetC { get; set; }
        public int TargetCal { get; set; }

        public BasicInfo()
        {
            CurrentWeight = 60;
            TargetWeight = 50;
            TargetP = 100;
            TargetF = 40;
            TargetC = 100;
            TargetCal = 1600;
        }
    }
}
