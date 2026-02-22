using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Birds.Speices
{
    class Penguin : Bird
    {
        private string habitat; //tropical, arctic etc

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nHabitat = {Habitat}";
        }

    }
}
