using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//can manage a list of any type (in this project - Animal),
//BankAccount, Employee, or even primitive types such as
//int, double, or bool—without requiring code changes.
namespace EcoParkV2.GenericList
{
    //provides all behaviors which are defined in the interface

    //inherits from interface, with T that could be any datatype
    class ListManager<T> : IListManager<T>
    {
    }
}
