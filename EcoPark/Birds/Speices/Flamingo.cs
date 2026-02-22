using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Birds.Speices
{
    class Flamingo : Bird
    {
        private readonly string[] colorIntensity = { "light pink", "medium pink", "dark pink" };

        public string ColorIntensity { get; set; }

        //check if array value is correct in here
        public override string ToString()
        {
            return $"{base.ToString()}\nColor intensity = {ColorIntensity}";
        }
    }
}
