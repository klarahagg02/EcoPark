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

        //properties to get/set the instance variables
        public int NumOfEyes 
        { 
            get { return numOfEyes; } 
            set { numOfEyes = value; }
        }
        public bool IsPoisonous
        {
            get { return isPoisonous; }
            set { isPoisonous = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string isPoisonous = IsPoisonous ? $"Yes" : "No";
            return $"{base.ToString()}\nNumber of eyes = {NumOfEyes}\nIs poisonous = {isPoisonous}\n";
        }
    }
}