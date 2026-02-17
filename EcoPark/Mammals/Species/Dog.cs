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
        private bool isTrained;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public bool IsTrained
        {
            get { return isTrained; }
            set { isTrained = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
