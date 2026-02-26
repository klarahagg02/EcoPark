using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Insects.Species
{
    class Bee : Insect
    {
        private string typeOfBee;

        //properties to get/set the instance variable
        public string TypeOfBee
        {
            get { return typeOfBee; }
            set { typeOfBee = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nType of bee = {TypeOfBee}";
        }
    }
}
