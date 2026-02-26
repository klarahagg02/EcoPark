using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Insects.Species;

namespace EcoPark.Insects
{
    /// <summary>
    /// Factory class to be able to create insect objects, to reduce code repetition and make it easier for future use
    /// if I want to add more species. It'll be easier to maintain the code from here.
    /// </summary>
    class InsectFactory
    {
        //method to create insects with the same base properties,
        //then add on special properties for the species based on a switch case, and return the insect object
        public static Insect CreateInsect(InsectSpecies species, bool canFly, string color)
        {
            Insect insect;

            switch (species)
            {
                case InsectSpecies.Bee:
                    insect = new Bee
                    {
                        TypeOfBee = string.Empty
                    };
                    break;
                case InsectSpecies.Ladybug:
                    insect = new Ladybug
                    {
                        NumOfDots = 0
                    };
                    break;
                default:
                    return null;
            }

            insect.CanFly = canFly;
            insect.Color = color;
            return insect;
        }
    }
}
