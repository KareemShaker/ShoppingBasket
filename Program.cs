using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating new items using paramaterized instructor 
            Item i1 = new Item(001, "Tomato", 2.60m);
            Item i2 = new Item(002, "Milk", 1.30m);
            Item i3 = new Item(003, "Tissue", 1.65m);
            //creating new basket object
            Basket b1 = new Basket();
            //adding items to the basket using AddItem method which accepts one parameter as an item object
            b1.AddItem(i1);
            b1.AddItem(i2);
            b1.AddItem(i3);
            b1.AddItem(i2);
            // adding more than one item to the basket at the same time
            b1.AddItems(i1, i3);
            
            //printing out the contents of the basket using the toString method.
            Console.WriteLine(b1.ToString());
            
            // calculating and printing out the total of the basket using the CalcTotal method
            Console.WriteLine("Total={0:c2}", b1.CalcTotal());

            //removing one item from the basket using the RemoveItem Method
            b1.RemoveItem(i3);
            
            //remove three items at a time using removeItems Method
            b1.RemoveItems(i1, i2, i3);
            
            //clearing the Basket using ClearBasket Method
            b1.ClearBasket();
            
            
            Console.WriteLine(b1.ToString());
            Console.WriteLine("Total={0:c2}", b1.CalcTotal());

        }
    }
}
