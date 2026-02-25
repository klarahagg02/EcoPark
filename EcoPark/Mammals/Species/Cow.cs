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

        public Cow(int milkProduction)
        {
            this.milkProduction = milkProduction;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nMilk production = {MilkProduction} liters";
        }
    }
}
