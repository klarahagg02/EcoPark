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

        public void SetNewID(Animal animal)
        {
            if (animal == null)
                return;

            CategoryType category = animal.Category;
            string newID = string.Empty;

            if(category == CategoryType.Mammal)
            {
                newID = "MAM";

            }
            else if (category == CategoryType.Amphibian)
            {
                newID = "AM";
            }
            else if (category == CategoryType.Bird)
            {
                newID = "B";
            }
            else if (category == CategoryType.Marine)
            {
                newID = "MAR";
            }
            else if (category == CategoryType.Insect)
            {
                newID = "I";
            }
            else if (category == CategoryType.Reptile)
            {
                newID = "R";
            }
            else if (category == CategoryType.Arachnid)
            {
                newID = "AR";
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
    }
}
