class Monster
{
    public string Name{get;set;}
    public int Hp{get; set;}

    public static List<Monster> AllMobs = new List<Monster>();

    public Monster(string name , int hp)
    {
        Name = name;
        Hp = hp;

        AllMobs.Add(this);
    }

    public virtual void attack(Monster target)
    {
        Console.WriteLine($"{Name} attacks  {target.Name}");
    }

    public void takedamage(int damage)
    {
        Hp -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. HP = {Hp}");
    }


}