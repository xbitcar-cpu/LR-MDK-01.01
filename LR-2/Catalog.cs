using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    struct Catalog
    {
        public void Print(List<Product> products)
        {
            Console.WriteLine("Прайс-лист:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + products[i].Name + " - "
                    + products[i].Price + " руб., " + products[i].Stock + " шт.");
            }
        }

        public void PrintStock(List<Product> products)
        {
            Console.Write("Остатки на складе: ");
            for (int i = 0; i < products.Count; i++)
            {
                if (i > 0) Console.Write(", ");
                Console.Write(products[i].Name + " " + products[i].Stock);
            }
            Console.WriteLine();
        }
    }
}

