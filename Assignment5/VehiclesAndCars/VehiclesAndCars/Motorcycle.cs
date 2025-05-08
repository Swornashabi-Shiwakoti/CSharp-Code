// Written by Swornashabi
// 2/26/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Motorcycle: Vehicle
    {
        private bool hasSidecar = false;

        public bool HasSidecar
        {
            get { return this.hasSidecar; }
            set { this.hasSidecar = value; }
        }

        public Motorcycle(string aMake, string theModel, int theYear) : base(aMake, theModel, theYear)
        {

        }

        public override string ToString()
        {
            string msg = "";
            msg += this.Year + " " + this.Make + " " + this.Model + " (Has Sidecar: " + this.HasSidecar + ")";
            return msg;
        }
    }
}
