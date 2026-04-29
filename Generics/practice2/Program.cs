namespace Practice2
{
    #region What is ArrayList?
    /*
        ArrayList (non-generic, old C#):
        - Stores any object, no type safety
        - Suffers from boxing/unboxing for value types
        - Runtime errors if you mix types

        Core features to implement:
        1. Add(T item)        — append an element
        2. T Get(int index)   — retrieve by index
        3. Remove(int index)  — delete by index, shift left
        4. Count property     — how many elements are stored
        5. Print()            — display all elements
    */
    #endregion

    #region MyArrayList<T>

    class MyArrayList<T>
    {
        private T[] _data;       // internal fixed array
        private int _count = 0;  // how many slots are actually used

        public int Count => _count;

        public MyArrayList(int capacity = 4) => _data = new T[capacity];

        // --- Add ---
        public void Add(T item)
        {
            // If internal array is full, double its size
            if (_count == _data.Length)
                Resize();

            _data[_count] = item;
            _count++;
        }

        // --- Get by index ---
        public T Get(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException($"Index {index} is out of range (Count = {_count})");

            return _data[index];
        }

        // --- Indexer: lets you write list[0] instead of list.Get(0) ---
        public T this[int index]
        {
            get => Get(index);
            set
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException($"Index {index} is out of range (Count = {_count})");
                _data[index] = value;
            }
        }

        // --- Remove by index ---
        public void Remove(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException($"Index {index} is out of range (Count = {_count})");

            // Shift every element after `index` one step to the left
            for (int i = index; i < _count - 1; i++)
                _data[i] = _data[i + 1];

            _data[_count - 1] = default!; // clear the last slot
            _count--;
        }

        // --- Print all elements ---
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_data[i]);
                if (i < _count - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        // --- Private: double the internal array when full ---
        private void Resize()
        {
            T[] bigger = new T[_data.Length * 2];
            for (int i = 0; i < _data.Length; i++)
                bigger[i] = _data[i];
            _data = bigger;
        }
    }

    #endregion

    #region Program
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== int list ===");
            MyArrayList<int> intList = new();

            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            intList.Add(50); // triggers Resize (capacity was 4)
            intList.Add(60);

            intList.Print();                         // [10, 20, 30, 40, 50, 60]
            Console.WriteLine($"Count: {intList.Count}"); // 6

            // Indexer get
            Console.WriteLine($"Index 2: {intList[2]}");  // 30

            // Indexer set
            intList[2] = 99;
            intList.Print();                         // [10, 20, 99, 40, 50, 60]

            // Remove middle element
            intList.Remove(2);
            intList.Print();                         // [10, 20, 40, 50, 60]
            Console.WriteLine($"Count: {intList.Count}"); // 5

            Console.WriteLine("\n=== string list ===");
            MyArrayList<string> strList = new();
            strList.Add("Apple");
            strList.Add("Banana");
            strList.Add("Cherry");
            strList.Print();                         // [Apple, Banana, Cherry]

            strList.Remove(0);
            strList.Print();                         // [Banana, Cherry]

            Console.WriteLine("\n=== out of range test ===");
            try
            {
                Console.WriteLine(intList.Get(100));
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Caught: {e.Message}");
            }
        }
    }
    #endregion
}
