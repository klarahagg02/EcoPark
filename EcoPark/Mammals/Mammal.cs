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

        //empty constructor
        public Mammal()
        {
        }


        //call CreateMammal from MammalFactory to create
        //the mammal objects in the constructor of the species classes (Cat, Dog, Cow)

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
