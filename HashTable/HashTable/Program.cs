using System;
using System.Collections;
using System.Collections.Generic;
namespace Lesson4_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable");

            #region HashTable
            //HashTable is a collection of key/value pairs that are organized based on the hash code of the key.
            Hashtable hashtable = new Hashtable();

            #endregion

            #region Add
            //Add method is used to add key/value pairs to the hashtable.
            //cannot add duplicate keys to the hashtable, if you try to add a duplicate key, it will throw an exception.
            hashtable.Add(1,"123");             
            hashtable.Add("123",2);
            hashtable.Add(true,false);
            hashtable.Add(false, true);
            #endregion


            #region Remove
            //Remove method is used to remove a key/value pair from the hashtable.
            hashtable.Remove(1);

            //No response if the key does not exist in the hashtable.
            hashtable.Remove(2);

            //Clear
            hashtable.Clear();
            hashtable.Add(1,"123");
            hashtable.Add(2,"1234");
            hashtable.Add(3,"123");
            hashtable.Add("123123", 12);


            #endregion


            #region Search
            //Search for a value in the hashtable using the key.
            //If the key does not exist in the hashtable, it will return null.
            Console.WriteLine(hashtable[1]);
            Console.WriteLine(hashtable["123123"]);

            if (hashtable.Contains(1))
            {
                Console.WriteLine("Key exists in the hashtable.");
            }

            if(hashtable.ContainsKey(1))
            {
                Console.WriteLine("Key exists in the hashtable.");
            }

            if(hashtable.ContainsValue("123"))
            {
                Console.WriteLine("Value exists in the hashtable.");
            }

            #endregion

            #region Modify
            //Modify the value of a key in the hashtable.
            hashtable[1] = "12345";
            Console.WriteLine(hashtable[1]);
            #endregion


            #region Count
            //Count property is used to get the number of key/value pairs in the hashtable.
            Console.WriteLine(hashtable.Count);

            //Keys property is used to get a collection of keys in the hashtable.   
            foreach(object item in hashtable.Keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item, hashtable[item]);
            }

           foreach(object item in hashtable.Values)
            {
                Console.WriteLine("Value: {0}", item);
            } 


            //Iterate through the hashtable using DictionaryEntry. 
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            IDectionaryEnumerator enumerator = hashtable.GetEnumerator();
            bool hasNext = enumerator.MoveNext();

            #endregion


        }
    }
}