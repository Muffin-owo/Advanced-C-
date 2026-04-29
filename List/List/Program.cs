using System.Collections;
using System.Collections.Generic;
using System.Xml;
namespace Lesson7_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List");


            #region What is List
            // A List is a dynamic array:

            // Stores multiple values
            // Can grow or shrink automatically
            // Keeps elements in order (index-based)
            #endregion




            #region List vs ArrayList
            // List only support one specific type
            // ArrayList support multiple type

            // Performance List > ArrayList
            // No Casting for List

            #endregion

            #region  define


            List<int> list = new List<int>();
            List<string> list2 = new List<string>();
            List<bool> list3 = new List<bool>();

    

            #endregion


            #region add
            list.Add(1);
            list.Add(1);

            List<int> listint = new List<int>();
            listint.Add(123);
            list.AddRange(listint);
            #endregion
            
            #region remove

            list.Remove(1);

            //remove specific location
            list.RemoveAt(0);

            //clear
            list.Clear();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            #endregion

            #region search

            Console.WriteLine(list[0]);

            //check is it exist
            if (list.Contains(1))
            {
                Console.WriteLine("found");
            }

            int index = list.IndexOf(5);
            Console.WriteLine(index);

            index = list.LastIndexOf(2);
            Console.WriteLine(index);

            #endregion

            #region modify

            Console.WriteLine(list[0]);
            list[0] = 99;
            Console.WriteLine(list[0]);


            #endregion

            #region 
            //length
            Console.WriteLine(list.Count);
            //Capacity
            Console.WriteLine(list.Capacity);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region practice1

            List<int> num = new List<int>();

            for(int i = 10; i >= 1; i--)
            {
                num.Add(i);
            }

            foreach(int item1 in num)
            {
                Console.WriteLine(item1);
            }

            num.RemoveAt(4);

            foreach(int item1 in num)
            {
                Console.WriteLine(item1);
            }

            #endregion


        }
    }
}