using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Insects
{
    class Insect : Animal
    {
        private bool canFly;
        private string color;

        //properties to get/set the instance variables
        public bool CanFly
        {
            get { return canFly; }
            set { canFly = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string canFly = CanFly ? $"Yes" : "No";
            return $"{base.ToString()}\nCan fly = {canFly}\nColor = {Color}\n";
        }
    }
}
