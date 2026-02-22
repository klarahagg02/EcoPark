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
            return $"{base.ToString()}\nLiving deph = {LivingDepth} meters\nColor = {Color}\n";
        }
    }
}
