using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Reptiles.Species
{
    class Turtle : Reptile
    {
        private string shellColor;

        //property to get/set the instance variable
        public string ShellColor
        {
            get { return shellColor; }
            set { shellColor = value; }
        }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            return $"{base.ToString()}\nShell color = {ShellColor}";
        }

        //override ToStringSummary() method to output the object in the listbox, adds on from the baseclass
        public override string ToStringSummary()
        {
            return $"{"Turtle",-8} {base.ToStringSummary()}";
        }
    }
}
