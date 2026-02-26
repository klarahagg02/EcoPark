using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Birds.Speices;

namespace EcoPark.Birds
{
    /// <summary>
    /// Factory class to be able to create Bird objects, to reduce code repetition and make it easier for future use
    /// if I want to add more species. It'll be easier to maintain the code from here.
    /// </summary>
    class BirdFactory
    {
        //method to create birds with the same base properties,
        //then add on special properties for the species based on a switch case, and return the bird object
        public static Bird CreateBird(BirdSpecies species, int wingspan, bool canFly)
        {
            Bird bird;

            switch (species)
            {
                case BirdSpecies.Pelican:
                    bird = new Pelican
                    {
                        BeakLength = 0.0
                    };
                    break;
                case BirdSpecies.Penguin:
                    bird = new Penguin
                    {
                        Habitat = string.Empty
                    };
                    break;
                default:
                    return null;
            }
            bird.Wingspan = wingspan;
            bird.CanFly = canFly;
            return bird;
        }
    }
}
