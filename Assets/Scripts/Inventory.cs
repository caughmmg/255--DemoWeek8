using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caughman
{

    public enum Item
    {
        None,
        Pants,
        Shirt,
        Skirt,
        Gloves
    }




    public class Inventory
    {
        //our Inventory Singleton accessible via Inventory.main
        public static readonly Inventory main = new Inventory();

        public Dictionary<Item, bool> items = new Dictionary<Item, bool>();

        public Item itemBeingUsed = Item.None;

        public bool HasItem(Item item)
        {
            if (!items.ContainsKey(item)) return false;

            return items[item];
        }

        public void Set(Item item, bool shouldHave = true)
        {
            if (items.ContainsKey(item))
            {
                items[item] = shouldHave;
            }
            else
            {
                items.Add(item, shouldHave);
            }
        }
        

        private Inventory()
        {
            
        }
    }
}
