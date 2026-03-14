using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark;
using EcoParkV2.AnimalsGen;

namespace EcoPark.AnimalsGen
{
    //the parent class for all animals in the park. 
    //its abstract because we dont want to be able to create an animal object without specifics (category, species)
    public abstract class Animal : IAnimal
    {

        private int id;
        private string name;
        private int age;
        private GenderType gender;
        private int weight;

        //properties to get/set the instance variables. to get access
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

        //to represent the objects in text-form in the output
        public override string ToString()
        {
            return $"Name = {Name}\nAge = {Age}\nWeight = {Weight}g\nGender = {Gender}\n";
        }
    }
}
