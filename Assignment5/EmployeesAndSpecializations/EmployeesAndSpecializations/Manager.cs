// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    public class Manager: Employee
    {
        // additional property
        private int numberOfEmployeesManaged = -1;

        //gets and sets
        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        //chaining to base constructor
        public Manager(string aName, int aSalary): base(aName, aSalary)
        {

        }

        //overriding ToString()
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: {this.Salary}, Number of employees managed = {this.NumberOfEmployeesManaged}";
        }
    }
}
