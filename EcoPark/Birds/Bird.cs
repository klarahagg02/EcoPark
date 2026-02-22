using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Birds
{
    class Bird : Animal
    {
        private int wingspan;
        private bool canFly;

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

        //check bool
        public override string ToString()
        {

            string canFly = CanFly ? $"Yes" : "No";
            return $"{base.ToString()}\nWingspan = {Wingspan}\nCan fly = {canFly}\n";
        }
    }
}
