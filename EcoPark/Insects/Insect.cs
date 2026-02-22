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

        //check if bool is correct
        public override string ToString()
        {
            string canFly = CanFly ? $"Yes" : "No";
            return $"{base.ToString()}\nCan fly = {canFly}\nColor = {Color}";
        }
    }
}
