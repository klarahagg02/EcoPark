using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark;

namespace EcoPark.Mammals
{
    class Mammal : Animal
    {
        private int numOfLegs;
        private int tailLength;
        
        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
