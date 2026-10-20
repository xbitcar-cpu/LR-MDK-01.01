using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "хлеб", "молоко", "сыр", "колбаса", "масло" };
            List<int> prices = new List<int> { 45, 80, 350, 420, 120 };
            List<int> stock = new List<int> { 30, 25, 12, 8, 15 };

            int[] ordered = new int[names.Count];

            Catalog catalog = new Catalog();
            catalog.Print(names, prices, stock);

            InputReader inputReader = new InputReader();
            inputReader.ReadOrder(names.Count, ordered);

            OrderProcessor orderProcessor = new OrderProcessor();
            bool ok = orderProcessor.TryPlaceOrder(names, prices, stock, ordered, out int total);

            if (ok)
            {
                Console.WriteLine("Стоимость заказа: " + total + " руб.");
            }
            else
            {
                Console.WriteLine("Заказ отклонён: не хватило товара — " + orderProcessor.MissingName);
            }

            catalog.PrintStock(names, stock);
        }
    }
}