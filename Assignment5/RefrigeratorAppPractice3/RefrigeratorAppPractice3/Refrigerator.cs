using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {
        public int MaxWeight { get; set; }
        public int CurrentWeight { get; set; }

        bool flag = false;

        public int SetAddWeight
        {
            set
            {
                AddWeight(value);
            }
            get
            {
                return Convert.ToInt32(flag);
            }

        }

        public int RemainingWeight
        {
            get {return GetRemainingWeight(); }
        }

        private bool AddWeight(int weight)
        {
            int CheckWeight = CurrentWeight + weight;
            
            if (CheckWeight <= MaxWeight)
            {
                CurrentWeight += weight;
                return flag = false;
            }
            else
            {
                return flag = true;
            }
        }

        private int GetRemainingWeight()
        {
            int remaingWeight = MaxWeight - CurrentWeight;
            return remaingWeight;
        }
    }
}
