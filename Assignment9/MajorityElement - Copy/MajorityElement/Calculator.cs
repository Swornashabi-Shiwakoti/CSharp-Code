// Written by Swornashabi
// 4/25/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    public class Calculator
    {
        public int GetMajorityElement(List<int> nums)
        {
            int candidate = 0;
            int count = 0;

            foreach(int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}
