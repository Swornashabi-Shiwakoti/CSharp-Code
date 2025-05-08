

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public abstract class Shape
    {
        //class variables
        private string color = "n/a";

        //gets and sets
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //constructor
        public Shape(string aColor)
        {
            this.Color = aColor;
        }

        // abstract method
        public abstract double GetArea();

        // overriding ToString
        public override string ToString()
        {
            return $"Shape Color: {this.Color}";
        }

    }
}
