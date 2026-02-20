using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Reptiles.Species
{
    class Turtle : Reptile
    {
        //find an unique attrubute for turtle soon!
        private string shellColor;

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
