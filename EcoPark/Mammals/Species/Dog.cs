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

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public Dog(string breed)
        {
            this.breed = breed;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nBreed = {Breed}";
        }
    }
}
