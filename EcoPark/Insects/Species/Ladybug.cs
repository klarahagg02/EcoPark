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

        public int NumOfDots
        {
            get { return numOfDots; }
            set { numOfDots = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
