using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Mammals.Species
{
    class Cow : Mammal
    {
        private int milkProduction;

        public int MilkProduction
        {
            get { return milkProduction; }
            set { milkProduction = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
