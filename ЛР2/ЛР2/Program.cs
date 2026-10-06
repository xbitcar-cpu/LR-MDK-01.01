using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "хлеб", "молоко", "сыр", "колбаса", "масло" };
            List<int> prices = new List<int> { 45, 80, 350, 420, 120 };
            List<int> stock = new List<int> { 30, 25, 12, 8, 15 };

            int[] ordered = new int[names.Count];

            Catalog.Print(names, prices, stock);

            InputReader.ReadOrder(names.Count, ordered);

            bool ok = OrderProcessor.TryPlaceOrder(names, prices, stock, ordered, out int total);

            if (ok)
            {
                Console.WriteLine("Стоимость заказа: " + total + " руб.");
            }
            else
            {
                Console.WriteLine("Заказ отклонён: не хватило товара — " + OrderProcessor.MissingName);
            }

            Catalog.PrintStock(names, stock);
        }
    }
}
