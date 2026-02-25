using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoPark.Arachnids.Species;

namespace EcoPark.Arachnids
{
    class ArachnidFactory
    {
        public static Arachnid CreateArachnid(ArachnidSpecies species, int numOfEyes, bool isPoisonous)
        {
            Arachnid arachnid;

            switch (species)
            {
                case ArachnidSpecies.Spider:
                    arachnid = new Spider
                    {
                        ProduceWeb = false
                    };
                    break;
                case ArachnidSpecies.Scorpion:
                    arachnid = new Scorpion
                    {
                        ClawLength = 0
                    };
                    break;
                default:
                    return null;
            }

            arachnid.NumOfEyes = numOfEyes;
            arachnid.IsPoisonous = isPoisonous;
            return arachnid;
        }
    }
}
