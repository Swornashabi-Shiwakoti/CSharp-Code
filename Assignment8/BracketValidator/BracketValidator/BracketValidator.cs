//Written by Swornashabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketValidator
{
    public class BracketValidator
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> bracketMap = new Dictionary<char, char>
            {
                {')','(' },
                {'}','{' },
                {']','[' }
            };

            foreach (char c in s)
            {
                if (bracketMap.ContainsKey(c))
                {
                    char top = stack.Count > 0 ? stack.Pop() : '#';
                    if (top != bracketMap[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
    }
}
