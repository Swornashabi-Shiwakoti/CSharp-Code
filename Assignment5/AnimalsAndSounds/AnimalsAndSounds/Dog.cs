// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Dog: Animal
    {
        //chaining to base constructor
        public Dog(string aName): base(aName)
        {

        }

        // overriding MakeSound()
        public override string MakeSound()
        {
            return "Bark";
        }
    }
}
