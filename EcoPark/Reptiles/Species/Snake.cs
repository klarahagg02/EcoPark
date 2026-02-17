using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Reptiles.Species
{
    class Snake : Reptile
    {
        private bool isVenomous;

        public bool IsVenomous
        {
            get { return isVenomous; }
            set { isVenomous = value; }
        }


        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
