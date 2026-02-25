using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Amphibians.Species;

namespace EcoPark.Amphibians
{
    public class AmphibianFactory
    {
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
