// Written by Swornashabi
// 2/26/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Vehicle
    {
        //class variables
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        //gets and sets
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // full constructor
        public Vehicle(string aMake, string theModel, int theYear)
        {
            this.Make = aMake;
            this.Model = theModel;
            this.Year = theYear;
        }


        //overriding ToString()
        public override string ToString()
        {
            string msg = "";
            msg += this.Year + " " + this.Make + " " + this.Model;
            return msg;
        }

    }
}
