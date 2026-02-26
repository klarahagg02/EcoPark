using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Marine.Species;

namespace EcoPark.Marine
{
    /// <summary>
    /// Factory class to be able to create marine objects, to reduce code repetition and make it easier for future use
    /// if I want to add more species. It'll be easier to maintain the code from here.
    /// </summary>
    class MarineFactory
    {
        //method to create marines with the same base properties,
        //then add on special properties for the species based on a switch case, and return the marine object
        public static Marine CreateMarine(MarineSpecies species, int livingDepth, string color)
        {
            Marine marine;

            switch (species)
            {
                case MarineSpecies.Octopus:
                    marine = new Octopus
                    {
                        SquirtsInk = false
                    };
                    break;
                case MarineSpecies.Shark:
                    marine = new Shark
                    {
                        Carnivore = false
                    };
                    break;
                default:
                    return null;
            }

            marine.LivingDepth = livingDepth;
            marine.Color = color;
            return marine;
        }
    }
}
