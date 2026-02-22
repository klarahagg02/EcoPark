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

        public double BeakLength
        {
            get { return beakLength; }
            set { beakLength = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nBeak length = {BeakLength}";
        }
    }
}
