using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EcoPark.Amphibians
{
    public class Amphibian : Animal
    {
        private bool livesInWater;
        private string color;


        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }

    }
}
