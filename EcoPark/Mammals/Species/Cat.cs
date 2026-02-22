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

        //check if allergyFriendly is right or if it should be the outher way round
        public override string ToString()
        {
            string allergyFriendly = AllergyFriendly ? $"Yes" : "No";
            return $"{base.ToString()}\nAllergy friendly = {allergyFriendly}";

        }
    }
}
