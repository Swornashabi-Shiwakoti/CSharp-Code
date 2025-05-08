// Written by Swornashabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class BaseballGame
    {
        public int CalPoints(string[] operations)
        {
            Stack<int> record = new Stack<int>();

            foreach(string op in operations)
            {
                if (op == "+")
                {
                    int last = record.Pop();
                    int secondLast = record.Peek();
                    record.Push(last);
                    record.Push(last + secondLast);
                }
                else if (op == "D")
                {
                    record.Push(2 * record.Peek());
                }
                else if (op == "C")
                {
                    record.Pop();
                }
                else
                {
                    record.Push(int.Parse(op));
                }
            }

            int total = 0;
            foreach (int score in record)
            {
                total += score;
            }

            return total;
        }
    }
}
