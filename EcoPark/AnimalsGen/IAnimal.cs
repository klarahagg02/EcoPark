using EcoPark.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkV2.AnimalsGen
{
    //this class will define what all subclasses must have
    public interface IAnimal
    {
        //a sort of contract that all animals must have a name, age and gender
        string Name { get; set; }
        int Age { get; set; }
        GenderType Gender { get; set; }

        //method that returns something (name, id, age etc)

        //string ToStringSummary(); //to be used for displaying in listboxes etc.

    }
}
