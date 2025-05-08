// Written by Swornashabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class PivotIndexFinder
    {
         public int PivotIndex(int[] nums)
        {
            int totalSum = 0;
            foreach(int num in nums)
            {
                totalSum += num;
            }

            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == totalSum - leftSum - nums[i])
                {
                    return i;
                }
                leftSum += nums[i];
            }

            return -1;
        }
    }
}
