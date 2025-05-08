// Written by Swornashabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balloon
{
    public class BalloonCounter
    {
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }

            int b = count.ContainsKey('b') ? count['b'] : 0;
            int a = count.ContainsKey('a') ? count['a'] : 0;
            int l = count.ContainsKey('l') ? count['l'] / 2 : 0;
            int o = count.ContainsKey('o') ? count['o'] / 2 : 0;
            int n = count.ContainsKey('n') ? count['n'] : 0;

            return Math.Min(Math.Min(Math.Min(b, a), 1), Math.Min(o, n));
        }
    }
}
