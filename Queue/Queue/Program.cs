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






        }
    }
}