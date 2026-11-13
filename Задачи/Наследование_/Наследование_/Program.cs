using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace Наследование_
{
    class Program
    {
        static Product CreateProduct(string type)
        {
            if (type == "Candy")
            {
                return new CandyProduct();
            }
            if (type == "IceCream")
            {
                return new IceCream_MoroZ_Product();
            }
            return null;
        }

        static List<Product> LoadProducts(string path)
        {
            List<Product> products = new List<Product>();
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i].Trim() == "")
                {
                    continue;
                }

                string[] parts = lines[i].Split(';');
                if (parts.Length != 4)
                {
                    Console.WriteLine("Строка " + (i + 1) + " пропущена: нужно 4 поля");
                    continue;
                }

                Product product = CreateProduct(parts[0].Trim());
                if (product == null)
                {
                    Console.WriteLine("Строка " + (i + 1) + " пропущена: неизвестный тип " + parts[0]);
                    continue;
                }

                double price;
                int count;
                bool priceOk = double.TryParse(parts[2].Trim().Replace(',', '.'),
                    NumberStyles.Float, CultureInfo.InvariantCulture, out price);
                bool countOk = int.TryParse(parts[3].Trim(), out count);
                if (!priceOk || !countOk)
                {
                    Console.WriteLine("Строка " + (i + 1) + " пропущена: неверное число");
                    continue;
                }

                product.Set(parts[1].Trim(), price, count);
                products.Add(product);
            }
            return products;
        }

        static List<string> CreateReport(List<Product> products)
        {
            List<string> report = new List<string>();
            report.Add("Название;Цена за единицу;Продано;Стоимость;Скидка %;Сумма с учетом скидки");

            foreach (Product product in products)
            {
                double cost = product.GetPrice() * product.GetCount();
                double discount = product.CalculateDiscount();
                double total = cost * (1 - discount / 100);

                report.Add(product.GetName() + ";" + product.GetPrice() + ";" + product.GetCount()
                    + ";" + cost + ";" + discount + ";" + total);
            }
            return report;
        }

        static void Main(string[] args)
        {
            string inputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt");
            string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output.txt");

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Файл не найден: " + inputPath);
                Console.ReadKey();
                return;
            }

            List<Product> products = LoadProducts(inputPath);
            List<string> report = CreateReport(products);

            File.WriteAllLines(outputPath, report, Encoding.UTF8);

            foreach (string line in report)
            {
                Console.WriteLine(line);
            }

            Process.Start("notepad.exe", outputPath);
        }
    }
}