namespace GenericSingleton
{
    #region Why Singleton?
    /*
        Singleton Pattern:
        - Guarantees that a class has exactly ONE instance.
        - Provides a global access point to that instance.

        Common uses: GameManager, AudioManager, ConfigManager, Logger

        Without generics, you must copy-paste the same code into every class:
            private static GameManager _instance;
            public static GameManager Instance => _instance ??= new GameManager();

        With a generic base class, you write it ONCE.
    */
    #endregion

    #region Generic Singleton Base Class

    // Constraints explained:
    //   where T : SingletonBase<T>   →  T must be a subclass of SingletonBase<T>  (self-referential)
    //   where T : new()              →  T must have a public parameterless constructor
    //                                   so we can call `new T()` inside this class
    class SingletonBase<T> where T : SingletonBase<T>, new()
    {
        private static T? _instance;

        public static T Instance
        {
            get
            {
                _instance ??= new T();
                return _instance;
            }
        }

        // Prevent external code from calling `new GameManager()` directly
        protected SingletonBase() { }
    }

    #endregion

    #region Concrete Singleton Classes (just inherit — no extra code needed)

    class GameManager : SingletonBase<GameManager>
    {
        public int Score { get; set; }

        public void PrintStatus()
        {
            Console.WriteLine($"[GameManager] Score = {Score}");
        }
    }

    class AudioManager : SingletonBase<AudioManager>
    {
        public float Volume { get; set; } = 1.0f;

        public void PrintStatus()
        {
            Console.WriteLine($"[AudioManager] Volume = {Volume}");
        }
    }

    #endregion

    #region Program
    class Program
    {
        static void Main()
        {
            // --- Basic usage ---
            GameManager.Instance.Score = 42;
            GameManager.Instance.PrintStatus();   // Score = 42

            AudioManager.Instance.Volume = 0.75f;
            AudioManager.Instance.PrintStatus();  // Volume = 0.75

            // --- Proving it's the SAME instance ---
            GameManager.Instance.Score = 100;

            GameManager gm1 = GameManager.Instance;
            GameManager gm2 = GameManager.Instance;

            Console.WriteLine($"Same instance? {ReferenceEquals(gm1, gm2)}"); // True
            Console.WriteLine($"gm1.Score = {gm1.Score}");                    // 100
            Console.WriteLine($"gm2.Score = {gm2.Score}");                    // 100 — same object

            // --- Each type has its own independent singleton ---
            Console.WriteLine($"\nGameManager type:  {GameManager.Instance.GetType().Name}");
            Console.WriteLine($"AudioManager type: {AudioManager.Instance.GetType().Name}");
        }
    }
    #endregion
}
