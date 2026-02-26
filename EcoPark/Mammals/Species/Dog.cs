using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Mammals.Species
{
    class Dog : Mammal
    {
        private string breed;

        //property to get/set the instance variable
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nBreed = {Breed}";
        }
    }
}
