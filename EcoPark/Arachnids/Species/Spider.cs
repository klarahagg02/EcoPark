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

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
