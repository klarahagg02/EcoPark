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

        //not sure about bee-type
        public override string ToString()
        {
            return $"{base.ToString()}\nType of bee = {TypeOfBee}";
        }
    }
}
