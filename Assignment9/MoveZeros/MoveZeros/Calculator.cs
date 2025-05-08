// Written by Swornashabi
// 4/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    public class Calculator
    {
        public List<int> MoveZeros(List<int> nums)
        {
            int position = 0;
            for(int i = 0; i < nums.Count; i++)
            {
                if (nums[i] != 0)
                {
                    nums[position] = nums[i];
                    position++;
                }
            }
            while (position < nums.Count)
            {
                nums[position] = 0;
                position++;
            }
            return nums;
        }
    }
}
