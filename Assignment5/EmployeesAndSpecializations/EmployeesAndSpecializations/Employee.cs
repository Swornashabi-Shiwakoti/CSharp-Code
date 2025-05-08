// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    public class Employee
    {
        // class variables
        private string name = "n/a";
        private double salary = -1;

        // gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        //constructor
        public Employee(string aName, double aSalary)
        {
            this.Name = aName;
            this.Salary = aSalary;
        }

        //overriding ToString()
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: {this.Salary}";
        }
    }
}
