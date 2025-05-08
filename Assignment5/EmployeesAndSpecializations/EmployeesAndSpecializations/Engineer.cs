// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    public class Engineer: Employee
    {
        //additional properties
        private string specialization = "n/a";

        //gets and sets
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        // chaining to base constructor 
        public Engineer(string aName, int aSalary): base(aName, aSalary)
        {

        }

        // overriding ToString()
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: {this.Salary}, Specialization: {this.Specialization}";
        }
    }
}
