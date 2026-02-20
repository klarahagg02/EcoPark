using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EcoPark.Mammals.Species
{
    class Cat : Mammal
    {
        //instance variable
        private bool allergyFriendly;

        //constructor
        public Cat(bool allergyFriendly)
        {
            this.allergyFriendly = allergyFriendly;

        }

        //property to get/set the instance variable
        public bool AllergyFriendly
        {
            get { return allergyFriendly; }
            set { allergyFriendly = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
