using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    internal class Catalog
    {
        public static void Print(List<string> names, List<int> prices, List<int> stock)
        {
            Console.WriteLine("Прайс-лист:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + names[i] + " — " + prices[i] + " руб., " + stock[i] + " шт.");
            }
        }

        public static void PrintStock(List<string> names, List<int> stock)
        {
            Console.Write("Остатки на складе: ");
            for (int i = 0; i < names.Count; i++)
            {
                if (i > 0) Console.Write(", ");
                Console.Write(names[i] + " " + stock[i]);
            }
            Console.WriteLine();
        }
    }
}
