using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Arachnids.Species
{
    class Scorpion : Arachnid
    {
        //find a unique attribute for scorpion soon!
        private int clawLength;

        public int ClawLength
        {
            get { return clawLength; }
            set { clawLength = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nClaw size = {ClawLength} cm";
        }

    }
}
