using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Birds
{
    abstract class Bird : Animal
    {
        private int wingspan;
        private bool canFly;

        //properties to get/set the instance variables
        public int Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }
        public bool CanFly
        {
            get { return canFly; }
            set { canFly = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string canFly = CanFly ? $"Yes" : "No";
            return $"{base.ToString()}\nWingspan = {Wingspan}\nCan fly = {canFly}\n";
        }
    }
}
