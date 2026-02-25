using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Reptiles.Species;

namespace EcoPark.Reptiles
{
    class ReptileFactory
    {
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
