using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Marine
{
    abstract class Marine : Animal
    {
        private int livingDepth; //in meters
        private string color;

        //properties to get/set the instance variables
        public int LivingDepth
        {
            get { return livingDepth; }
            set { livingDepth = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nLiving deph = {LivingDepth} meters\nColor = {Color}\n";
        }
    }
}
