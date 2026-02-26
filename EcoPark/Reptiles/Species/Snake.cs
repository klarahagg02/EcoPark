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

        //property to get/set the instance variable
        public bool IsVenomous
        {
            get { return isVenomous; }
            set { isVenomous = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string isVenomous = IsVenomous ? $"Yes" : "No";
            return $"{base.ToString()}\nVenomous = {isVenomous}";
        }
    }
}
