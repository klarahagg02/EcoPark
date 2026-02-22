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

        //check if bool is correct
        public override string ToString()
        {
            string isVenomous = IsVenomous ? $"Yes" : "No";
            return $"{base.ToString()}\nVenomous = {isVenomous}";
        }
    }
}
