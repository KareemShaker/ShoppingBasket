using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class Item
    {
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; private set; }
        public Item(int code, string name, decimal price)
        {
            ItemCode = code;
            ItemName = name;
            ItemPrice = price;
        }
        public void ChangePrice(decimal newPrice)
        {
            ItemPrice = newPrice;
        }
    }
}
