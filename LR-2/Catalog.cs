using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    class Catalog
    {
        public static void Print(List<string> names, List<int> prices, List<int> stock)
        {
            Console.WriteLine("Прайс-лист:");                         
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + names[i] + " - "   
                    + prices[i] + " руб., " + stock[i] + " шт.");
            }
        }
    }
}
