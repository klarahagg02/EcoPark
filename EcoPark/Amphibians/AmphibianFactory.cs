using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Amphibians.Species;

namespace EcoPark.Amphibians
{
    /// <summary>
    /// Factory class to be able to create amphibian objects, to reduce code repetition and make it easier for future use
    /// if I want to add more species. It'll be easier to maintain the code from here.
    /// </summary>
    public class AmphibianFactory
    {
        //method to create amphibians with the same base properties,
        //then add on special properties for the species based on a switch case, and return the amphibian object
        public static Amphibian CreateAmphibian(AmphibianSpecies species, bool livesInWater, string color)
        {
            Amphibian amphibian;

            switch (species)
            {
                case AmphibianSpecies.Axolotl:
                    amphibian = new Axolotl
                    {
                        RegrowLimbs = false
                    };
                    break;
                case AmphibianSpecies.Frog:
                    amphibian = new Frog
                    {
                        IsPoisonous = false
                    };
                    break;
                default:
                    return null;
            }

            amphibian.LivesInWater = livesInWater;
            amphibian.Color = color;
            return amphibian;
        }
    }
}
