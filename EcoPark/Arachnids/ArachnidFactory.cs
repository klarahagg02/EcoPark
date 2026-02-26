using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Arachnids.Species;

namespace EcoPark.Arachnids
{
    
    /// <summary>
    /// Factory class to be able to create Arachnid objects, to reduce code repetition and make it easier for future use
    /// if I want to add more species. It'll be easier to maintain the code from here.
    /// </summary>
    class ArachnidFactory
    {
        //method to create arachnids with the same base properties,
        //then add on special properties for the species based on a switch case, and return the arachnid object
        public static Arachnid CreateArachnid(ArachnidSpecies species, int numOfEyes, bool isPoisonous)
        {
            Arachnid arachnid;

            switch (species)
            {
                case ArachnidSpecies.Spider:
                    arachnid = new Spider
                    {
                        ProduceWeb = false
                    };
                    break;
                case ArachnidSpecies.Scorpion:
                    arachnid = new Scorpion
                    {
                        ClawLength = 0
                    };
                    break;
                default:
                    return null;
            }

            arachnid.NumOfEyes = numOfEyes;
            arachnid.IsPoisonous = isPoisonous;
            return arachnid;
        }
    }
}
