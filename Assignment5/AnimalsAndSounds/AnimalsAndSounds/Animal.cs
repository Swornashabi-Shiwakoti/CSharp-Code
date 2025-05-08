// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Animal
    {
        //class variables
        private string name = "n/a";

        //gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor
        public Animal(string aName)
        {
            this.Name = aName;
        }

        //virtual method
        public virtual string MakeSound()
        {
            return $"Some generic animal sound";
        }

        //overriding ToString()
        public override string ToString()
        {
            return $"Animal: {this.Name}, Sound: {MakeSound()}";
        }
    }
}
