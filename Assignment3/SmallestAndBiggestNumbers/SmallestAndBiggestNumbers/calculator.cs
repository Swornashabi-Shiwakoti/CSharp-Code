// Written by Swornashabi
// 2/14/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestAndBiggestNumbers
{
    public class Calculator
    {
        public int FindMin(List<int> aList)
        {

            // 1, 2, 3, 4, 5
            int min = aList[0];

            foreach ( int i in aList)
            {
                if(i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        public int FindMax(List<int> aList)
        {
            int max = aList[0];

            foreach (int i in aList )
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public List<int> FindMinMax(List<int> aList)
        {
            List<int> aListOfMinMax = new List<int>();

            int min = FindMin(aList);
            int max = FindMax(aList);

            aListOfMinMax.Add(min);
            aListOfMinMax.Add(max);

            return aListOfMinMax;
        }
    }
}
