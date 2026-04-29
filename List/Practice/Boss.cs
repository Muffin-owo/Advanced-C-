class Boss : Monster
{
    public Boss(string name , int hp): base(name, hp)
    {
        
    }

    public override void attack(Monster target)
    {
        Console.WriteLine($"Boss {Name} attack {target.Name} ");
        target.takedamage(30);
    }
    
}