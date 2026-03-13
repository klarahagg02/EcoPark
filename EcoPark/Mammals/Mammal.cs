using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark;

namespace EcoPark.Mammals
{
    abstract class Mammal : Animal
    {
        //instance variables
        private int numOfLegs;
        private int tailLength;

        //properties to get/set the instance variables
        public int NumOfLegs
        {
            get { return numOfLegs; }
            set { numOfLegs = value; }
        }
        public int TailLength
        {
            get { return tailLength; }
            set { tailLength = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nNumber of legs = {NumOfLegs}\nTail length = {TailLength}\n";
        }
    }
}
