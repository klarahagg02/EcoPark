using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark;

namespace EcoPark.AnimalsGen
{
    //abstract class - cannot be instantiated, only inherited from. this is the parent class
    public abstract class Animal
    {
        //this class should ONLY have the default constructor

        //instance variables - data that all objects will have IN them.
        //these are the "attributes" of the animals where the data is stored
        private int id;
        private string name;
        private int age;
        private GenderType gender;
        private int weight;
        //imagePath (add later)

        //properties to get/set the instance variables. to get access
        //double check if they all should look like this or not...
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        //add methods common to all animals


        //to represent the objects in text-form in the output
        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Age: {Age}, Weight: {Weight}g";
        }

    }
}
