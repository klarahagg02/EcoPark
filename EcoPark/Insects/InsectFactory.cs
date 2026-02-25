using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Insects.Species;

namespace EcoPark.Insects
{
    class InsectFactory
    {
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
