using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Marine.Species
{
    class Octopus : Marine
    {
        private int numOfLegs;
        private bool squirtsInk;

        public int NumOfLegs
        {
            get { return numOfLegs; }
            set { numOfLegs = value; }
        }

        public bool SquirtsInk
        {
            get { return squirtsInk; }
            set { squirtsInk = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
