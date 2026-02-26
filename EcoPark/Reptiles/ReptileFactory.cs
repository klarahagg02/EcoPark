using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Reptiles.Species;

namespace EcoPark.Reptiles
{
    /// <summary>
    /// Factory class to be able to create reptile objects, to reduce code repetition and make it easier for future use
    /// if I want to add more species. It'll be easier to maintain the code from here.
    /// </summary>
    class ReptileFactory
    {
        //method to create reptiles with the same base properties,
        //then add on special properties for the species based on a switch case, and return the reptile object
        public static Reptile CreateReptile(ReptileSpecies species, int bodyLength, bool livesInWater)
        {
            Reptile reptile;

            switch (species)
            {
                case ReptileSpecies.Snake:
                    reptile = new Snake
                    {
                        IsVenomous = false
                    };
                    break;
                case ReptileSpecies.Turtle:
                    reptile = new Turtle
                    {
                        ShellColor = string.Empty
                    };
                    break;
                default:
                    return null;
            }

            reptile.BodyLength = bodyLength;
            reptile.LivesInWater = livesInWater;
            return reptile;
        }
    }
}
