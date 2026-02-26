using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Insects.Species
{
    class Ladybug : Insect
    {
        private int numOfDots;

        //properties to get/set the instance variable
        public int NumOfDots
        {
            get { return numOfDots; }
            set { numOfDots = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nNumber of dots = {NumOfDots}";
        }
    }
}
