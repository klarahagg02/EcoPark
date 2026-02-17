using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Insects
{
    class Insect : Animal
    {
        private bool canFly;
        private string color;

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
