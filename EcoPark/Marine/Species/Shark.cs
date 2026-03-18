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

        //property to get/set the instance variable
        public bool Carnivore
        {
            get { return carnivore; }
            set { carnivore = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string carnivore = Carnivore ? $"Yes" : "No";
            return $"{base.ToString()}\nCarnivore = {carnivore}";
        }

        //override ToStringSummary() method to output the object in the listbox, adds on from the baseclass
        public override string ToStringSummary()
        {
            return $"{"Shark",-8} {base.ToStringSummary()}";
        }
    }
}
