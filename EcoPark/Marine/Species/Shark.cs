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

        //check if bool is correct
        public override string ToString()
        {
            string carnivore = Carnivore ? $"Yes" : "No";
            return $"{base.ToString()}\nCarnivore = {carnivore}";
        }
    }
}
