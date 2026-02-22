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

        public bool SquirtsInk
        {
            get { return squirtsInk; }
            set { squirtsInk = value; }
        }

        //check if bool is correct
        public override string ToString()
        {
            string squirtsInk = SquirtsInk ? $"Yes" : "No";
            return $"{base.ToString()}\nSquirts ink = {squirtsInk}";
        }
    }
}
