    using System;
    public class Program
    {
    public static void Main(string[] args)
    {
        ItemManager manager = new ItemManager(1000);

        Item sword = new Item("Sword", 300);
        Item shield = new Item("Shield", 200);

        manager.BuyItem(sword);
        manager.BuyItem(shield);

        manager.ShowBag();

        manager.SellItems("Sword");
        manager.ShowBag();





      }
    }
