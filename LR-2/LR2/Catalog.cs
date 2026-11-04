using System;
using System.Collections.Generic;

namespace LR2
{
    public struct Catalog
    {
        public void Print(List<Product> products)
        {
            Console.WriteLine("Прайс-лист:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + products[i].Name_ + " - "
                    + products[i].Price_ + " руб., " + products[i].Stock_ + " шт.");
            }
        }

        public void PrintStock(List<Product> products)
        {
            Console.Write("Остатки на складе: ");
            for (int i = 0; i < products.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(products[i].Name_ + " " + products[i].Stock_);
            }
            Console.WriteLine();
        }
    }
}
