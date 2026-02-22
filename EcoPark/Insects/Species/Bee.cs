using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Insects.Species
{
    class Bee : Insect
    {
        private string typeOfBee;

        //check if this is correct
        public string TypeOfBee
        {
            get { return typeOfBee; }
            set { typeOfBee = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nType of bee = {TypeOfBee}";
        }
    }
}
