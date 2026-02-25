using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Marine.Species;

namespace EcoPark.Marine
{
    class MarineFactory
    {
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
