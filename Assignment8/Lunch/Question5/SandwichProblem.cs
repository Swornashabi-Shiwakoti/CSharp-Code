// Written by Sornashabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public class SandwichProblem
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> studentQueue = new Queue<int>(students);
            int sandwichIndex = 0;
            int attempts = 0;

            while (studentQueue.Count > 0 && attempts < studentQueue.Count)
            {
                if (studentQueue.Peek() == sandwiches[sandwichIndex])
                {
                    studentQueue.Dequeue();
                    sandwichIndex++;
                    attempts = 0;
                }

                else
                {
                    studentQueue.Enqueue(studentQueue.Dequeue());
                    attempts++;
                }
            }

            return studentQueue.Count;
        }
    }
}
