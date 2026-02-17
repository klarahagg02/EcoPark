using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Birds
{
    class Bird : Animal
    {
        //wingspan
        //sjö/landfågel
        //antal gånger de häckar
        //antal ägg per runda
        //canfly
        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
