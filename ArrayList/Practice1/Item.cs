using System;
using System.Collections;

     public class Item
    {
        public string name{get; set;}
        public int price{get; set;}

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }


        public override string ToString()
        {
            return "Name: " + name + ", Price: " + price;
        }


    }
