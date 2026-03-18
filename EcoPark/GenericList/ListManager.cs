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
    public class ListManager<T> : IListManager<T>
    {
        //internal list, stores all objects of type T
        private List<T> list;

        //constructor
        public ListManager() 
        {
            list = new List<T>();
        }

        //property
        public List<T> ListOfAnimals
        {
            get { return list; }
        }
        //double check!
        public int Count {  get { return list.Count; } }

        //adds to list
        public bool Add(T type)
        {
            if (type is null)
                return false;
            list.Add(type);
            return true;
        }
        //changes object at specific index
        public bool ChangeAt(T type, int index)
        {
            if (type is null)
                return false;
            if (CheckIndex(index))
            {
                list[index] = type;
                return true;
            }
            return false;
        }
        //checks if index is in list
        public bool CheckIndex(int index)
        {
            //index nr can't be negative nr or be larger than indexes in list
            return index >= 0 && index < list.Count;
        }
        //deletes all objects in list
        public void DeleteAll()
        {
            list.Clear();
            //list.Count = 0;
        }
        //deletes object at specific index, if index is valix
        public void DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                list.RemoveAt(index);
            }
        }
        //returns object at specific index
        public T GetAt(int index)
        {
            if (CheckIndex(index))
            {
                return list[index];
            }
            //maybe add (T) at the end
            return default;
        }
        //returns all objects in array as text
        public string[] ToStringArray()
        {
            //creates the array
            string[]array = new string[list.Count];
            //loop to convert to string
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i] is null ? string.Empty : list[i].ToString();
            }
            return array;
        }
        //returns a list of strings instead of array
        public List<string> ToStringList()
        {
            //created the list
            List<string> listOfStrings = new List<string>();
            //loop to convert to string
            //switch item to type?
            foreach (T item in list)
            {
                listOfStrings.Add(item is null ? string.Empty : item.ToString());
            }
            return listOfStrings;
        }

    }
}
