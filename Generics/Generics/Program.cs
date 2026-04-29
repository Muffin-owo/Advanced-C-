using System;
using System.Collections.Generic;


namespace Lesson5_Generics{



            #region Generics
            //What is Generics?
            //Generics allow us to create classes, methods, and data structures that can work with any data type while providing type safety at compile time.
            //Benefits of Generics:
            //1. Type Safety: Generics ensure that you can only use the specified data type, preventing runtime errors.
            //2. Code Reusability: You can create a single class or method that can
            //   work with different data types without code duplication.
            //3. Performance: Generics can improve performance by eliminating the need for boxing and unboxing when working with value types.

            //Example of a Generic Class
            //Generic Class
            //class MyGenericClass<T>
            //interface IMyGenericInterface<T>

            //Example of a Generic Method
            //Generic Method
            //public void MyGenericMethod<T>(T parameter)
            #endregion


            #region 

            class TestClass<T>
            {
                public T value;
            }

            class TestClass2<T1, T2 , K , M>
            {
                public T1 value1;
                public T2 value2;
                public K value3;
                public M value4;
            }

            interface TestInterface<T>
            {
                T value { get; set; }
            }
            

            class Test : TestInterface<int>
            {
                public int value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            }


            #endregion



            #region 

            class Test2
            {
               public void TestFun<T>(T value)
                {
                    Console.WriteLine(value);
                }

                public void TestFun<T>()
                {
                    T t = default(T);

                }

                public T TestFun<T>(string v)
                {
                   return default(T);     
                }

                public void TestFun<T , K , M>(T t , K k , M m)
                {
                    
                }

            }

            


            #endregion

            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Generics");

                    TestClass<int> t = new TestClass<int>();
                    t.value = 10;
                    Console.WriteLine("Value: " + t.value);

                    TestClass<string> t2 = new TestClass<string>();
                    t2.value = "Hello, Generics!";
                    Console.WriteLine("Value: " + t2.value);

                    TestClass2<int, string, double, bool> t3 = new TestClass2<int, string, double, bool>();
                    t3.value1 = 42;
                    t3.value2 = "Generics";
                    t3.value3 = 3.14;
                    t3.value4 = true;

                    Console.WriteLine("Value1: " + t3.value1);
                    Console.WriteLine("Value2: " + t3.value2);
                    Console.WriteLine("Value3: " + t3.value3);
                    Console.WriteLine("Value4: " + t3.value4);


                    Test2 test2 = new Test2();
                    test2.TestFun<int>(100);
                    test2.TestFun<string>("Hello, World!");


        
                    }  
            }  
}
