//Written by Swornashabi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public class Rectangle: Shape
    {
        //additional properties
        private double width = -1;
        private double height = -1;

        //gets and sets
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // constructor 
        public Rectangle(string aColor, double theWidth, double theHeight): base(aColor)
        {
            this.Width = theWidth;
            this.Height = theHeight;
        }

        // method
        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        // overriding ToString()
        public override string ToString()
        {
            return $"Rectangle's width: {Width}, height:{Height}, Area: {GetArea()}";
        }
    }
}
