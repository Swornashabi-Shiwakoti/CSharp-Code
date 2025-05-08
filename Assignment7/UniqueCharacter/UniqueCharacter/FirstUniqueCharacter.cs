//Written by Swornashabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacter
{
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                    return i;
            }

            return -1;
        }

    }
}
