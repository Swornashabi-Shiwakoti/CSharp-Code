// Written by Swornashabi
// 2/16/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountD
{
    public class Calculator
    {
        public int CountDs(string aString)
        {
            int count = 0;
            foreach (char c in aString)
            {
                if (c.ToString() == "D" || c.ToString() == "d")
                {
                    count += 1;
                }
            }

            return count;
        }
    }
}
