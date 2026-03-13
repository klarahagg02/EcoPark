using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Reptiles
{
    abstract class Reptile : Animal
    {
        private int bodyLength; //in cm
        private bool livesInWater;

        //properties to get/set the instance variables
        public int BodyLength
        {
            get { return bodyLength; }
            set { bodyLength = value; }
        }
        public bool LivesInWater
        {
            get { return livesInWater; }
            set { livesInWater = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string livesInWater = LivesInWater ? $"Yes" : "No";
            return $"{base.ToString()}\nBody length = {BodyLength}\nLives in water = {livesInWater}";
        }
    }
}
