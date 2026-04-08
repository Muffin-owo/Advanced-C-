using System;
using System.Collections;
    public class ItemManager
    {
        private ArrayList bag;
        private int money;

        public ItemManager(int initMoney)
        {
            bag = new ArrayList();
            money = initMoney;
        }

        public void BuyItem(Item item)
    {
        if(money >= item.price)
        {
            bag.Add(item);
            money -= item.price;
            Console.WriteLine("Bought " + item.name + " for " + item.price + ". Current money: " + money);
        }
        else
        {
            Console.WriteLine("Not enough money to buy " + item.name);
        }
    }

        public void SellItems(String name)
        {
          foreach(Item item in bag)
          {
            if(item.name == name)
             {
                bag.Remove(item);
                money += item.price;
                Console.WriteLine("Sold " + item.name + " for " + item.price + ". Current money: " + money);
                return;
             }
           }
           Console.WriteLine("Item " + name + " not found in bag."); 
        }

        public void ShowBag()
        {
            Console.WriteLine("Items in bag:");
            foreach(Item item in bag)
            {
                Console.WriteLine(item);
            }
        }

        public int GetMoney()
        {
            return money;
        }
    }
