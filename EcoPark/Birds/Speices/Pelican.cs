using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Birds.Speices
{
    class Pelican : Bird
    {
        private double beakLength;

        //properties to get/set the instance variable
        public double BeakLength
        {
            get { return beakLength; }
            set { beakLength = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nBeak length = {BeakLength}";
        }
    }
}
