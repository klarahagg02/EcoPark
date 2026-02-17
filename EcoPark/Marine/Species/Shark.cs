using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Marine.Species
{
    class Shark : Marine
    {
        private bool carnivore;

        public bool Carnivore
        {
            get { return carnivore; }
            set { carnivore = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
