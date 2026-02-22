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

        public bool ProduceWeb
        {
            get { return produceWeb; }
            set { produceWeb = value; }
        }

        //check if bool is correct
        public override string ToString()
        {
            string produceWeb = ProduceWeb ? $"Yes" : "No";
            return $"{base.ToString()}\nProduce web = {produceWeb}";
        }
    }
}
