// Written by Swornashabi
// 2/26/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Car : Vehicle
    {
        //additional property
        private int numOfDoors = 0;

        public int NumOfDoors
        {
            get { return this.numOfDoors; }
            set { this.numOfDoors = value; }
        }

        public Car(string aMake, string theModel, int theYear): base(aMake, theModel, theYear)
        {
            
        }

        // overriding ToString()
        public override string ToString()
        {
            string msg = "";
            msg += this.Year + " " + this.Make + " " + this.Model + " " + "with " + " " + this.NumOfDoors + " " + "doors.";
            return msg;
        }
    }
}
