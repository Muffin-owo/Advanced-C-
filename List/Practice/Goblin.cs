class Goblin : Monster
{
    public Goblin(string name , int hp) : base(name , hp){}

    public override void attack(Monster target)
    {
        Console.WriteLine($"Goblin {Name} attack {target.Name} ");
        target.takedamage(10);
    }
}
    