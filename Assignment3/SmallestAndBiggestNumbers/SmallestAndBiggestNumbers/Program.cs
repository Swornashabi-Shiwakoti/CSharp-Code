// Written by Swornashabi
// 2/14/2025

using System;
using System.Collections.Generic;

namespace SmallestAndBiggestNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> aList = new List<int> { 1, 2, 3, 4, 5 };

            Calculator aCalculator = new Calculator();

            int minimum = aCalculator.FindMin(aList);
            int maximum = aCalculator.FindMax(aList);
            List<int> aListOfResults = aCalculator.FindMinMax(aList);

            Console.WriteLine("The minimum of the list is: " + minimum);
            Console.WriteLine("The maximum of the list is: " + maximum);
            Console.WriteLine("The list with minimum and maximum: " + new List<int>(){1,5});
        }
    }
}
