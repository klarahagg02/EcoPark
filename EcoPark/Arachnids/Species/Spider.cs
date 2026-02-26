using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Arachnids.Species
{
    class Spider : Arachnid
    {
        private bool produceWeb;

        //properties to get/set the instance variable
        public bool ProduceWeb
        {
            get { return produceWeb; }
            set { produceWeb = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string produceWeb = ProduceWeb ? $"Yes" : "No";
            return $"{base.ToString()}\nProduce web = {produceWeb}";
        }
    }
}
