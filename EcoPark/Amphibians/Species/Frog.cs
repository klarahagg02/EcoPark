using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPark.Amphibians.Species
{
    public class Frog : Amphibian
    {
        private bool isPoisonous;

        //proprty to reach and use the instance variable
        public bool IsPoisonous 
            {
            get {return isPoisonous;}
            set {isPoisonous = value;}
            }

        //override ToString() method to print the object and handling polymorphism. Adds on from its parent.
        public override string ToString()
        {
            string isPoisonous = IsPoisonous ? $"Yes" : "No";
            return $"{base.ToString()}\nIs poisonous = {isPoisonous}";
        }

        //override ToStringSummary() method to output the object in the listbox, adds on from the baseclass
        public override string ToStringSummary()
        {
            return $"{"Frog",-8} {base.ToStringSummary()}";
        }
    }
}
