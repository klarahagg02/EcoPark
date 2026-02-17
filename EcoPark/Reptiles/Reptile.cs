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
        private readonly string[] aggressivenessLevel = { "Low", "Medium", "High" };

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
