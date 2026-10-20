using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
            internal class Program
        {
            static void Main(string[] args)
            {
                System.Console.OutputEncoding = System.Text.Encoding.UTF8;

                SaleHistory Storage = new SaleHistory();
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 15), "Футбольный мяч", 10, 2500.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 17), "Баскетбольный мяч", 8, 2800.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 14), "Волейбольный мяч", 12, 2200.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 12), "Гантели", 15, 900.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 13), "Скакалка", 25, 350.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 7), "Коврик для йоги", 10, 1200.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 8), "Шлем", 11, 3000.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 3), "Наколенники", 34, 600.00));
                Storage.AddSale(new SaleItem(new System.DateTime(2026, 10, 9), "Боксёрские перчатки", 27, 750.00));

                Nomenclature Group = new Nomenclature();
                Group.AddProduct(ProductGroup.Balls, "Футбольный мяч");
                Group.AddProduct(ProductGroup.Balls, "Баскетбольный мяч");
                Group.AddProduct(ProductGroup.Balls, "Волейбольный мяч");
                Group.AddProduct(ProductGroup.Fitness, "Гантели");
                Group.AddProduct(ProductGroup.Fitness, "Скакалка");
                Group.AddProduct(ProductGroup.Fitness, "Коврик для йоги");
                Group.AddProduct(ProductGroup.Protection, "Шлем");
                Group.AddProduct(ProductGroup.Protection, "Наколенники");
                Group.AddProduct(ProductGroup.Protection, "Боксёрские перчатки");

                ProfitByPeriodReport periodReport = Accountant.MakeReport(Storage, new System.DateTime(2026, 8, 1), new System.DateTime(2026, 12, 31));

                System.Console.WriteLine("Отчёт за период:");

                foreach (ReportRow row in periodReport.GetReportRows())
                {
                    System.Console.WriteLine(row.Product_ + ": " + row.Count_ + " шт., " + row.Cost_ + " руб.");
                }

                ProfitByProductGroupReport groupReport = Accountant.MakeGroupReport(periodReport, Group);

                System.Console.WriteLine();
                System.Console.WriteLine("Отчёт по товарным группам:");

                foreach (GroupReportRow row in groupReport.GetReportRows())
                {
                    System.Console.WriteLine(row.Group_ + ": " + row.Count_ + " шт., " + row.Cost_ + " руб.");
                }
            }
        }
    }
    }
}
