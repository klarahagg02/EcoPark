using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Marine
{
    class Marine : Animal
    {
        private bool isPredator;
        private int livingDepth; //in meters
        private string color;

        public bool IsPredator 
        { 
            get {  return isPredator; }
            set { isPredator = value; }
        }

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

        public override string ToString()
        {
            string isPredator = IsPredator ? $"Yes" : "No";
            return $"{base.ToString()}\nIs predator = {isPredator}\nLiving deph = {LivingDepth} meters\nColor = {Color}\n";
        }
    }
}
