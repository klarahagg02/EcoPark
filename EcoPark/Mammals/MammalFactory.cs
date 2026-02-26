using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark;
using EcoPark.Insects.Species;
using EcoPark.Insects;
using EcoPark.Mammals.Species;

namespace EcoPark.Mammals

{
    class MammalFactory
    {
        //method to create mammals with the same base properties,
        //then add on special properties for the species based on a switch case, and return the mammal object
        public static Mammal CreateMammal(MammalSpecies species, int numOfLegs, int tailLength)
        {
            Mammal mammal;

            switch (species)
            {
                case MammalSpecies.Cat:
                    mammal = new Cat
                    {
                        AllergyFriendly = false
                    };
                    break;
                        
                case MammalSpecies.Dog:
                    mammal = new Dog
                    {
                        Breed = string.Empty
                    };
                    break;
                case MammalSpecies.Cow:
                    mammal = new Cow
                    {
                        MilkProduction = 0
                    };
                    break;
                default:
                    return null;
            }
            mammal.NumOfLegs = numOfLegs;
            mammal.TailLength = tailLength;
            return mammal;
        }
    }
}
    
