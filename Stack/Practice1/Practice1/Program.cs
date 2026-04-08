using System;
using System.Collections;

namespace Stack_Practice1
{
    class Program
    {

        public static void DecimalToBinary(int number)
        {
             Stack stack = new Stack();
            while(number > 0)
            {
                int remainder = number % 2;
                stack.Push(remainder);
                number /= 2;
            }

            Console.Write("Binary: ");
            foreach(object item in stack)
            {
                Console.Write(item);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Stack Practice1");
            Console.WriteLine("==================");
            Console.WriteLine("Input number you want transfer to binary: ");
            int number = int.Parse(Console.ReadLine());
            DecimalToBinary(number);
        }
    }
}