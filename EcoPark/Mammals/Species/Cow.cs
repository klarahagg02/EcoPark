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

        //property to get/set the instance variable
        public int MilkProduction
        {
            get { return milkProduction; }
            set { milkProduction = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nMilk production = {MilkProduction} liters";
        }

        //override ToStringSummary() method to output the object in the listbox, adds on from the baseclass
        public override string ToStringSummary()
        {
            return $"{"Cow",-8} {base.ToStringSummary()}";
        }
    }
}
