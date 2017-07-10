using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class Basket
    {
        //initializinf a generic list of type items to store items added to the basket
        List<Item> ItemList = new List<Item>();

        //AddItem method responsible for adding on item at atime to the basket
        public void AddItem(Item item)
        {
            //adding item to the List of Items
            ItemList.Add(item);
        }

        //AddItems method is for adding more than one item at a time using params of Item
        public void AddItems(params Item[] items)
        {
            //adding the array of items to the list
            ItemList.AddRange(items);
        }

        //RemoveItem method is for removing one item at atime from the basket
        public void RemoveItem(Item item)
        {
            //check if the list is empty
            if (ItemList.Count > 0)
            {
                if (!ItemList.Remove(item)) //check if the item to be removed is in the list
                {
                    Console.WriteLine(item.ItemName + " Not found in basket");
                }
                else //confirming removing the item
                {
                    Console.WriteLine(item.ItemName + " is removed");
                }
            }
            else
            {
                Console.WriteLine("Basket is Empty!! can't remove item!!");
            }
        }

        //RemoveItems method is responsible for removing more than one item at a time
        public void RemoveItems(params Item[] items)
        {
            //iterating throught the array of items
            foreach (Item item in items)
            {
                //calling RemoveItem method and passing the item to be removed
                RemoveItem(item);
            }
        }

        // ClearBasket method is for clearing the list from items 
        public void ClearBasket()
        {
            //confirming clearing the basket
            Console.WriteLine("Clear Basket!! Are you sure?\n Y=Yes - any key to abort!!");
            //reading input from user
            string userInput = Console.ReadLine();
            //check if user input is "Y"
            if (userInput == "Y")
            {
                //clearing the list
                ItemList.Clear();
                Console.WriteLine("Basket is cleared");
            }
        }
        //CalcTotal Method is for calculating the total price of the items 
        public decimal CalcTotal()
        {
            decimal total = 0;
            foreach (Item item in ItemList)
            {
                total += item.ItemPrice;
            }
            return total;
        }

        //overriding method ToString to printout the basket
        public override string ToString()
        {
            //creating new stringbuilder;
            StringBuilder details = new StringBuilder();
            foreach (Item item in ItemList)
            {
                details.AppendLine(string.Format("{0,3:D3} {1,-10} {2:c2}", item.ItemCode, item.ItemName, item.ItemPrice));
            }
            return details.ToString();
        }
    }
}
