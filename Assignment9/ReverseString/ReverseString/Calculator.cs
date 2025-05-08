// Written by Swornashabi
// 4/25/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class Calculator
    {
        public List<char> ReverseString(List<char> s)
        {
            int left = 0;
            int right = s.Count - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
            return s;
        }
    }
}
