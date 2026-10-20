using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    struct Product
    {
        public string Name;
        public int Price;
        public int Stock;

        public Product(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
