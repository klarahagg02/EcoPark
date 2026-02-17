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

        public override string ToString()
        {
            return base.ToString() + $"write things here";
        }
    }
}
