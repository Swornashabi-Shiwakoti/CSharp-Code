// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public class Circle: Shape
    {
        //additional properties
        private double radius = -1;

        // gets and sets
        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        //constructor
        public Circle(string aColor, double theRadius): base(aColor)
        {
            this.Radius = theRadius;
        }

        // method
        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        // overriding ToString()
        public override string ToString()
        {
            return $"Circle's radius: {this.Radius}, Area: {GetArea()}";
        }
    }
}
