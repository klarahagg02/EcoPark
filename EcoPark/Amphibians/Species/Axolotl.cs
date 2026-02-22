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

        public bool RegrowLimbs
        {
            get { return regrowLimbs; }
            set { regrowLimbs = value; }
        }

        //check bool if its correct
        public override string ToString()
        {
            string regrowLimbs = RegrowLimbs ? $"Yes" : "No";
            return $"{base.ToString()}\nCan regrow limbs = {regrowLimbs}";
        }
    }
}
