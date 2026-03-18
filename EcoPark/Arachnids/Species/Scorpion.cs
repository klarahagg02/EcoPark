using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Arachnids.Species
{
    class Scorpion : Arachnid
    {
        private int clawLength;

        //properties to get/set the instance variable
        public int ClawLength
        {
            get { return clawLength; }
            set { clawLength = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nClaw size = {ClawLength} cm";
        }

        public override string ToStringSummary()
        {
            return $"{"Scorpion",-8} {base.ToStringSummary()}";
        }
    }
}
