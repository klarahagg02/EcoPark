using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Reptiles
{
    class Reptile : Animal
    {
        private int bodyLength; //in cm
        private bool livesInWater;
        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
