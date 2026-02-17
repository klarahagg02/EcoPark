using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Insects.Species
{
    class Bee : Insect
    {
        private readonly string[] typeOfBee = { "honey bee", "carpenter bee", "queen"};

        //check if this is correct
        public string TypeOfBee { get; set; }


        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
