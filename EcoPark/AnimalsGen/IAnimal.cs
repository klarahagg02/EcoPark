using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkV2.AnimalsGen
{
    //this class defines what its subclass must have
    public interface IAnimal
    {
        //a "contract": all animals must have a name, age and gender
        string Name { get; set; }
        int Age { get; set; }
        GenderType Gender { get; set; }

        string ToStringSummary(); //used for print out animal objects in the listbox
    }
}
