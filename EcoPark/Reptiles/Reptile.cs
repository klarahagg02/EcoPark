using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Reptiles
{
    class Reptile : Animal
    {
        private int bodyLength; //in cm
        private bool livesInWater;

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

        //check if bool is correct
        public override string ToString()
        {
            string livesInWater = LivesInWater ? $"Yes" : "No";
            return $"{base.ToString()}\nBody length = {BodyLength}\nLives in water = {livesInWater}";
        }
    }
}
