// Written by Swornashabi
// 2/16/2025
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayValues
{
    public class Calculator
    {
        public List<int> MultiplyByLength(List<int> aList)
        {
            int length = aList.Count;
            List<int> result = new List<int>();
            foreach (int i in aList)
            {
                int newInt = i * length;
                result.Add(newInt);
            }
            return result;
        }
    }
}
