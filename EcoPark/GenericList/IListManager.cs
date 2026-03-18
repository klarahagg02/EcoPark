using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//can manage a list of any type (in this project - Animal),
//without requiring code changes.

//define all behaviors that are a must
namespace EcoParkV2.GenericList
{
    public interface IListManager<T>
    {
        //property, how many are in the list
        int Count { get; }

        //methods
        //add to list
        bool Add(T type);
        //change object at a specific index
        bool ChangeAt(T type, int index);
        //check if index is in list
        bool CheckIndex(int index);
        //delete all objects in list
        void DeleteAll();
        //deletes object at specific index
        void DeleteAt(int index);
        //get object at specific index
        T GetAt(int index);
        //returns all objects (or numbers etc) as an array ín text-form
        string[] ToStringArray();
        //returns all objects (or numbers etc) as a List of strings
        List<string> ToStringList();
    }
}
