namespace Lesson7_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("Dragon" , 1000);
            Goblin goblinA = new Goblin("Goblin A" , 20);
            Goblin goblinB = new Goblin("Goblin B" , 20);
            Goblin goblinC = new Goblin("Goblin C" , 20);


            goblinA.attack(goblinB);
            boss.attack(goblinA);


        }
    }
}

    
