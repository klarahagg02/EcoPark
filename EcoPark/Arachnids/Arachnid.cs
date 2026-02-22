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

        //check if bool is correct
        public override string ToString()
        {
            string isPoisonous = IsPoisonous ? $"Yes" : "No";
            return $"{base.ToString()}\nNumber of eyes = {NumOfEyes}\nIs poisonous = {isPoisonous}";
        }
    }
}