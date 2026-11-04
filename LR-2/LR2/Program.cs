using System;
using System.Collections.Generic;

namespace LR2
{
    internal struct Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> products = new List<Product>();
            products.Add(new Product("хлеб", 45, 30));
            products.Add(new Product("молоко", 80, 25));
            products.Add(new Product("сыр", 350, 12));
            products.Add(new Product("колбаса", 420, 8));
            products.Add(new Product("масло", 120, 15));

            Catalog catalog = new Catalog();
            catalog.Print(products);

            InputReader inputReader = new InputReader();
            int[] ordered = inputReader.ReadOrder(products.Count);

            OrderProcessor orderProcessor = new OrderProcessor();
            int total;
            if (orderProcessor.TryPlaceOrder(products, ordered, out total))
            {
                Console.WriteLine("Стоимость заказа: " + total + " руб.");
            }
            else
            {
                Console.WriteLine("Заказ отклонён: не хватило товара — " + orderProcessor.GetMissingName());
            }

            catalog.PrintStock(products);
        }
    }
}
