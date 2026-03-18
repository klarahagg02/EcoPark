using EcoPark.AnimalsGen;
using EcoParkV2.GenericList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkV2.AnimalsGen
{
    //get animal
    class AnimalManager : ListManager<Animal>
    {
        private static int startID = 100;

        //set id based on category using a switch case
        public void SetNewID(Animal animal)
        {
            if (animal == null)
                return;
            string newID = string.Empty;

            switch (animal.Category)
            {
                case CategoryType.Mammal:
                    newID = "MAM";
                    break;
                case CategoryType.Amphibian:
                    newID = "AM";
                    break;
                case CategoryType.Bird:
                    newID = "B";
                    break;
                case CategoryType.Marine:
                    newID = "MAR";
                    break;
                case CategoryType.Insect:
                    newID = "I";
                    break;
                case CategoryType.Reptile:
                    newID = "R";
                    break;
                case CategoryType.Arachnid:
                    newID = "AR";
                    break;
            }
            animal.Id = newID + startID++.ToString();
        }

        public bool AddAnimal(Animal animal)
        {
            if (animal == null)
                return false;

            if (string.IsNullOrWhiteSpace(animal.Id))
                SetNewID(animal);

            return Add(animal);
        }

        public bool DeleteAnimal(int index)
        {
            if (!CheckIndex(index))
                return false;

            // Route deletion through the generic list API so both layers are exercised.
            DeleteAt(index);
            return true;
        }

        //creating an array of all animals summaries
        public string[] ToStringSummaryAllAnimals()
        {
            //new array
            string[] infoStrings = new string[Count];
            //loop through array of animals and add the summary of each animal to the new array
            for (int i = 0; i < Count; i++)
            {
                Animal animal = ListOfAnimals[i];
                //double check if animal exists before using summary
                infoStrings[i] = animal is null ? string.Empty : animal.ToStringSummary();
            }
            return infoStrings;
        }
    }
}
