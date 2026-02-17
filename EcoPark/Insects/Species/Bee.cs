using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Insects.Species
{
    class Bee : Insect
    {
        //typeOfBee (arbetare, drottning osv)
        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
