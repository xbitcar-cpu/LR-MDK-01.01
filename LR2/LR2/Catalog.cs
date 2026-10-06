using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Catalog
    {
        public static List<Product> Create()
        {
            return new List<Product>
            {
                new Product("хлеб",    45,  30),
                new Product("молоко",  80,  25),
                new Product("сыр",     350, 12),
                new Product("колбаса", 420, 8),
                new Product("масло",   120, 15)
            };
        }
            public static void Print(List<Product> products)
        {
            Console.WriteLine("Прайс-лист:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + products[i].Name + " — "
                    + products[i].Price + " руб., " + products[i].Stock + " шт.");
            }
        }
    }
}

