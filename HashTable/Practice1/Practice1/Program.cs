using System;
using System.Collections;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monster Creator");
            MonsterManager monsterManager = new MonsterManager();
            monsterManager.createMonster("Goblin");
            monsterManager.createMonster("Slime");

            monsterManager.searchMonster(1);

            monsterManager.deleteMonster(1);

            monsterManager.displayAllMonsters();
            
        }
    }
}