using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Amphibians.Species
{
    public class Frog : Amphibian
    {
        //


        //this method first calls parent class then grandpartent class to get ALL of the
        //things that should be included in the output 
        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
