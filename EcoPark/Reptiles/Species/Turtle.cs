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

        public string ShellColor
        {
            get { return shellColor; }
            set { shellColor = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nShell color = {ShellColor}";
        }
    }
}
