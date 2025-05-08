// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Cat: Animal
    {
        //chaining to base constructor
        public Cat(string aName) : base(aName)
        {

        }

        // overriding MakeSound()
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
