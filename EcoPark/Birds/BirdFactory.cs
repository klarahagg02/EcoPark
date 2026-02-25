using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Birds.Speices;

namespace EcoPark.Birds
{
    class BirdFactory
    {
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
