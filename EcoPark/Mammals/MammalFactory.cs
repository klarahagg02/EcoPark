using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark;
using EcoPark.Mammals.Species;

namespace EcoPark.Mammals

{
    class MammalFactory
    {
        public static Mammal CreateMammal(MammalSpecies species, int numOfLegs, int tailLength)
        {
            Mammal mammal;

            switch (species)
            {
                case MammalSpecies.Cat:
                    mammal = new Cat(allergyFriendly: false);
                    break;
                case MammalSpecies.Dog:
                    mammal = new Dog(breed: "");
                    break;
                case MammalSpecies.Cow:
                    mammal = new Cow(milkProduction: 0);
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
    
