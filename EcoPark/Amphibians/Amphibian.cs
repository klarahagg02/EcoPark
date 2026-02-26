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

        //properties to get/set the instance variables
        public bool LivesInWater
        {
            get { return livesInWater; }
            set { livesInWater = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string livesInWater = LivesInWater ? $"Yes" : "No";
            return $"{base.ToString()}\nLives in water = {livesInWater}\nColor = {color}\n";
        }
    }
}