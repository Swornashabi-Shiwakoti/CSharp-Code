// Written by Swornashabi
// 2/16/2025

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayValues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> aList = new List<int> { 2, 3, 1, 0 };

            Calculator aCalculator = new Calculator();

            List<int> resultList = new List<int>();
            resultList = aCalculator.MultiplyByLength(aList);

            foreach (int i in resultList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
