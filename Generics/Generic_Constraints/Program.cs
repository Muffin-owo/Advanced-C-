namespace lesson6_Generic_Constraints
{
    #region 
    /*
    2. Six types of constraints

        a. Value type constraint:
        where T : struct

        b. Reference type constraint:
        where T : class

        c. Non-abstract class with a public parameterless constructor:
        where T : new()

        d. A specific class or its derived classes:
        where T : ClassName

        e. A type that implements a specific interface:
        where T : InterfaceName

        f. Another generic type or its derived type:
        where T : U
    */
    #endregion

    #region Value type constraint
    class Test1<T> where T: struct
    {
        public T value;

    public void TestFun<K>(K v) where K : struct
        {
            
        }
    }
    #endregion

    #region Reference type constraint
    class Test2<T> where T:class
    {
        public T value;

        public void TestFun<K>(K v) where K : class
        {
            
        }
    }

    #endregion


    #region  Non-abstract class with a public parameterless constructor
    class Test3<T> where T: new()
    {
        public T value;

    public void TestFun<K>(K v) where K : new()
        {
            
        }
    }


    class Test1
    {
        
    }

    class Test2
    {
        public Test2(int a)
        {
            
        }
    }



    #endregion

    #region A specific class or its derived classes

    class Test4<T> where T: Test1
    {
        public T value;

    public void TestFun<K>(K v) where K : Test1
        {
            
        }
    }

    class Test3 : Test1
    {
        
    }

    #endregion

    #region interface


    interface IFly
    {
        
    }
    class Test4 : IFly
    {
        
    }

    class Test5<T> where T: IFly
    {
        public T value;

    public void TestFun<K>(K v) where K : IFly
        {
            
        }
    }


    #endregion


    #region Another generic type or its derived type

     class Test6<T,U> where T: U
    {
        public T value;

    public void TestFun<K,V>(K k) where K : V
        {
            
        }
    }

    #endregion

    #region Generic Combination

    class Test7<T> where T : class , new()
    {
        
    }

    #endregion

    #region 
    class Test8<T,K> where T : class , new() where K : struct
    {
        
    }


    #endregion


    class Program
    {




        class TestClass<T, U>
        {
            public T t;
            public U u;

            public U TestFun(T t)
            {
                return default(U);
            }

            public V TestFun<K , V>(K k)
            {
                return default(V);
            }
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Generic_Constraints");

            TestClass<String , int> t = new TestClass<string, int>();

            t.t = "123131";
            t.u = 10;

            t.TestFun("123");

            t.TestFun<float , double>(1.4f);

            Test1<int> t1 = new Test1<int>();
            t1.TestFun<float>(1.3f);

            Test2<Random> t2 = new Test2<Random>();
            t2.value = new Random();
            

            Test3<Test1> t3 = new Test3<Test1>();

            Test4<Test1> t4 = new Test4<Test1>();
            Test4<Test3> t4_1 = new Test4<Test3>();


            Test5<IFly> t5 = new Test5<IFly>();
            t5.value = new Test4();


            Test6<Test4 , IFly> t6 = new Test6<Test4, IFly>();






            
        }
    }
}