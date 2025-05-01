using System;
using System.Collections.Generic;

namespace AbsoluteValue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> aList = new List<int> { 2, -1, 4, 8, 10 };

            Calculator aCalculator = new Calculator();

            int absSum = aCalculator.FindAbsSum(aList);

            Console.WriteLine(absSum);
        }
    }
}
