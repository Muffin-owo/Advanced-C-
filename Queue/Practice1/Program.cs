using System;
using System.Collections;


namespace Practice1
{
   class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Queue Practice 1");

            Queue queue = new Queue();

            Console.WriteLine("Input 10 Messages:");

            for (int i = 0; i < 10; i++)
            {
                string message = Console.ReadLine();
                queue.Enqueue(message);
            }

            foreach (object item in queue)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);// Wait for 1 second before printing the next message
            }
           

            
        }
    }
}