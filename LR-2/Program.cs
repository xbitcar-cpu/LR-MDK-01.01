using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("хлеб", 45, 30),
                new Product("молоко", 80, 25),
                new Product("сыр", 350, 12),
                new Product("колбаса", 420, 8),
                new Product("масло", 120, 15)
            };

            int[] ordered = new int[products.Count];

            Catalog catalog = new Catalog();
            catalog.Print(products);

            InputReader inputReader = new InputReader();
            inputReader.ReadOrder(products.Count, ordered);

            OrderProcessor orderProcessor = new OrderProcessor();
            bool ok = orderProcessor.TryPlaceOrder(products, ordered, out int total);

            if (ok)
            {
                Console.WriteLine("Стоимость заказа: " + total + " руб.");
            }
            else
            {
                Console.WriteLine("Заказ отклонён: не хватило товара — " + orderProcessor.MissingName);
            }

            catalog.PrintStock(products);
        }
    }
}
