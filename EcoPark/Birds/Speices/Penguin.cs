using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Birds.Speices
{
    class Penguin : Bird
    {
        private string habitat; //tropical, arctic, warm, cold etc

        //properties to get/set the instance variable
        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nHabitat = {Habitat}";
        }

    }
}
