using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark;

namespace EcoPark.AnimalsGen
{
    public class Animal
    {
        private int Id;
        private string Name;
        private int Age;
        private enum Gender;
        private int Weight;
        //imagePath

        //should ONLY have the default constructor:
        Animal()
        {

        }

        //add methods common to all animals

        //to represent the objects in text-form in the output
        public override string ToString()
        {
            return null;
            //return $"Id: {ID}, Name: {Name}, Gender: {Gender}, Age: {Age}, Weight: {Weight}g/kg";
            //numberoflegs?
        }

    }
}
