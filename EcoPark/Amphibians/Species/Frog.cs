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
        //have both instance variables and properties here!
        private bool isPoisonous;

        public bool IsPoisonous { get; set; }


        //this method first calls parent class then grandpartent class to get ALL of the
        //things that should be included in the output 
        //check if bool is correct
        public override string ToString()
        {
            string isPoisonous = IsPoisonous ? $"Yes" : "No";
            return $"{base.ToString()}\nIs poisonous = {isPoisonous}";
        }
    }
}
