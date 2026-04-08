using System;
using System.Collections;


namespace Lesson2_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");

        
            #region Stack
            // Stack: represents a last-in-first-out (LIFO) collection of objects
            // required System.Collections; namespace

            Stack stack = new Stack();

            #endregion

            #region push

            stack.Push(1);
            stack.Push("Hello");
            stack.Push(3.14);
            stack.Push(true);

            #endregion

            #region pop
            // Pop: removes and returns the object at the top of the Stack
            object v = stack.Pop();
            Console.WriteLine(v);

            #endregion

            #region search
            //only search for the top element
            //cannot search for an element in the middle of the stack
            // Peek: returns the object at the top of the Stack without removing it
            object v1 = stack.Peek();
            Console.WriteLine(v1);

            // Contains: determines whether an element is in the Stack
            if(stack.Contains("Hello")){
                Console.WriteLine("Found Hello");
            }
            #endregion

            #region clear
            // Clear: removes all elements from the Stack
            //stack.Clear();
            #endregion

            #region count
            // Count: gets the number of elements contained in the Stack
            Console.WriteLine($"Count: {stack.Count}");

            // Iterate through the Stack using foreach loop
            foreach(object item in stack){
                Console.WriteLine(item);
            }

            // ToArray: copies the Stack to a new array and returns it
            object[] array = stack.ToArray();
            for(int i = 0; i < array.Length; i++){
                Console.WriteLine(array[i]);
            }

            // Pop all elements from the Stack using a while loop
            while(stack.Count > 0){
                Console.WriteLine(stack.Pop());
            }


            #endregion


            
        }
    }
}