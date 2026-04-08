using System;
using System.Collections;

namespace Lesson1_ArrayList{
    class Test
    {
        
    }

    class Program{
    
         static void Main(string[] args){
            Console.WriteLine("ArrayList");


            // required System.Collections; namespace
            ArrayList array = new ArrayList();

            #region Add
            array.Add(1);
            array.Add("Hello");
            array.Add(3.14);
            array.Add(new object());
            array.Add(new Test());
            

            ArrayList array2 = new ArrayList();
            array2.Add(1);
            //Range: add a collection of items to the end of the ArrayList
            array.AddRange(array2);    
            // Insert: inserts an element into the ArrayList at the specified index   
            array.Insert(1, "First"); 
            Console.WriteLine(array[1]);

            #endregion

            #region delete
            // Remove: removes the first occurrence of a specific object from the ArrayList
            array.Remove(1);
            // RemoveAt: removes the element at the specified index of the ArrayList
            array.RemoveAt(2); 
            //Clear: removes all elements from the ArrayList
            //array.Clear();
            #endregion

            #region Search
            Console.WriteLine(array[0]);

            // Contains: determines whether an element is in the ArrayList
            if(array.Contains("Hello")){
                Console.WriteLine("Found Hello");
            }


            // IndexOf: returns the zero-based index of the first occurrence of a specific object in the ArrayList
            int index = array.IndexOf("Hello");
            if(index != -1){
                Console.WriteLine($"Found Hello at index {index}");
            }

            // LastIndexOf: returns the zero-based index of the last occurrence of a specific object in the ArrayList
            index = array.LastIndexOf("Hello");
            if(index != -1){
                Console.WriteLine($"Found Hello at index {index}");
            }



            
            #endregion

            #region Modify
            Console.WriteLine(array[0]); 
            array[0] = 42; // Modify the first element of the ArrayList
            Console.WriteLine(array[0]);
            #endregion
            

            #region Count
            // Count: gets the number of elements contained in the ArrayList
            Console.WriteLine(array.Count); 
            // Capacity: gets or sets the number of elements that the ArrayList can contain
            // If the number of elements exceeds the capacity, the capacity is automatically increased
            // The default capacity is 4, and it doubles when the capacity is exceeded
            // For example, if you add 5 elements to an ArrayList, the capacity will increase from 4 to 8
            Console.WriteLine(array.Capacity);

            Console.WriteLine("********************");
            for (int i = 0; i < array.Count; i++){
                Console.WriteLine(array[i]);
            }


            // foreach: iterates through the elements of the ArrayList
            foreach (var item in array){
                Console.WriteLine(item);
            }


            #endregion




     
        }
    }
}


