using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Arachnids
{
    class Arachnid : Animal
    {
        private int numOfEyes;
        private bool isPoisonous;

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
