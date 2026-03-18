using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Amphibians.Species
{
    public class Axolotl : Amphibian
    {
        private bool regrowLimbs;

        //property to reach and use the instance variable
        public bool RegrowLimbs
        {
            get { return regrowLimbs; }
            set { regrowLimbs = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string regrowLimbs = RegrowLimbs ? $"Yes" : "No";
            return $"{base.ToString()}\nCan regrow limbs = {regrowLimbs}";
        }

        //override ToStringSummary() method to output the object in the listbox, adds on from the baseclass
        public override string ToStringSummary()
        {
            return $"{"Axolotl",-8} {base.ToStringSummary()}";
        }
    }
}
