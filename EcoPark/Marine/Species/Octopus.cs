using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Marine.Species
{
    class Octopus : Marine
    {
        private bool squirtsInk;

        //property to get/set the instance variable
        public bool SquirtsInk
        {
            get { return squirtsInk; }
            set { squirtsInk = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string squirtsInk = SquirtsInk ? $"Yes" : "No";
            return $"{base.ToString()}\nSquirts ink = {squirtsInk}";
        }
    }
}
