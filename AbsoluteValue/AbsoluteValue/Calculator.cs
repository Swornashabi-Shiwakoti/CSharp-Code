//
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteValue
{
    public class Calculator
    {
        public int FindAbsSum(List<int> aList)
        {
            int AbsSum = 0;
            int AbsValue;
            foreach (int i in aList)
            {
                if(i < 0)
                {
                    AbsValue = i * (-1);
                }
                else
                {
                    AbsValue = i;
                }
                AbsSum += AbsValue;
            }
            return AbsSum;
        }
    }
}
