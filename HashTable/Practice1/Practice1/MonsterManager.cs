using System;
using System.Collections;

namespace Practice1
{
    public class MonsterManager
    {
        private Hashtable monsters = new Hashtable();
        private int nextId;

        public MonsterManager()
        {
            nextId = 1;
        }

        public void createMonster(string name)
        {
            Monster monster = new Monster(nextId , name);
            monsters.Add(nextId, monster);
            nextId++;
        }

        public void deleteMonster(int id)
        {
            if(monsters.ContainsKey(id))
            {
                monsters.Remove(id);
                Console.WriteLine("Monster with ID {0} deleted.", id);
            }
            else
            {
                Console.WriteLine("Monster with ID {0} not found.", id);
            }
        }

        public void searchMonster(int id)
        {
            if (monsters.ContainsKey(id))
            {
                Monster monster = (Monster)monsters[id];
                Console.WriteLine("Monster found: ID = {0}, Name = {1}", monster.id, monster.name);
            }
            else
            {
                Console.WriteLine("Monster with ID {0} not found.", id);
            }
        }

        public void displayAllMonsters()
        {
            Console.WriteLine("All Monsters:");
            
            foreach (DictionaryEntry entry in monsters)
            {
                Monster monster = (Monster)entry.Value;
                Console.WriteLine("ID = {0}, Name = {1}", monster.id, monster.name);
            }
        }



    }
}