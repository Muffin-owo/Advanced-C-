using System;
using System.Collections;
namespace Lesson3_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");

            #region Queue
            //Queue is a collection that follows the First In First Out (FIFO) principle. It is used to store a collection of objects in a specific order. The first object added to the queue will be the first one to be removed.
            //Using the System.Collections namespace, we can create a Queue object and perform various operations on it, such as Enqueue (adding an item to the end of the queue), Dequeue (removing an item from the front of the queue), and Peek (viewing the item at the front of the queue without removing it).
            Queue queue = new Queue();
            #endregion

            #region Enqueue
            //Enqueue is the operation of adding an item to the end of the queue.
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            #endregion

            #region Dequeue
            //Dequeue is the operation of removing an item from the front of the queue. It returns the item that was removed.
            object v = queue.Dequeue();
            Console.WriteLine(v); // Output: First
            #endregion


            #region Peek
            //Peek is the operation of viewing the item at the front of the queue without removing it. It returns the item at the front of the queue.
            object v2 = queue.Peek();
            Console.WriteLine(v2); // Output: Second

        
            if(queue.Contains("Third"))
            {
                Console.WriteLine("Queue contains 'Third'");
            }

            #endregion


            #region clear
            //Clear is the operation of removing all items from the queue.
            //queue.Clear();
             #endregion 

            #region Count
            //Count is a property that returns the number of items in the queue.
            Console.WriteLine(queue.Count); 

            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }


            object[] array = queue.ToArray();
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine(queue.Count); 

             #endregion






        }
    }
}