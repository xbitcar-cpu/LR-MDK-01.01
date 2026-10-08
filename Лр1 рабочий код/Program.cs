using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лр1_рабочий_код
{
    class Program
    {
        const double FreeDeliveryFrom = 2000;
        const double BaseCost = 150;
        const double BaseDistance = 3;
        const double CostPerKm = 50;
        const double PeakMultiplier = 1.3;
        static void Main(string[] args)
        {
            double orderCost = ReadNonNegativeNumber("Введите стоимость заказа (руб.): ");
            double distance = ReadNonNegativeNumber("Введите расстояние доставки (км): ");
            int hour = ReadHour("Введите время заказа (час): ");

            double deliveryCost = CalculateDeliveryCost(orderCost, distance, hour);
            double total = CalculateTotal(orderCost, deliveryCost);

            PrintResult(deliveryCost, total);
        }
        static double ReadNonNegativeNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Float,
                        CultureInfo.InvariantCulture, out double value)
                    || double.TryParse(input, out value))
                {
                    if (value >= 0)
                        return value;

                    Console.WriteLine("Ошибка: число не должно быть меньше нуля. Повторите ввод.");
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число. Повторите ввод.");
                }
            }
        }

        static int ReadHour(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int hour))
                {
                    if (hour >= 0 && hour <= 23)
                        return hour;

                    Console.WriteLine("Ошибка: время должно быть в диапазоне 0–23. Повторите ввод.");
                }
                else
                {
                    Console.WriteLine("Ошибка: введите целое число. Повторите ввод.");
                }
            }
        }
        static bool IsPeakHour(int hour)
        {
            return (hour >= 12 && hour <= 14) || (hour >= 18 && hour <= 20);
        }
        static double CalculateDeliveryCost(double orderCost, double distance, int hour)
        {
            if (orderCost >= FreeDeliveryFrom)
                return 0;

            double cost = BaseCost;
            if (distance > BaseDistance)
                cost += (distance - BaseDistance) * CostPerKm;

            if (IsPeakHour(hour))
                cost *= PeakMultiplier;

            return cost;
        }
        static double CalculateTotal(double orderCost, double deliveryCost)
        {
            return orderCost + deliveryCost;
        }
        static void PrintResult(double deliveryCost, double total)
        {
            Console.WriteLine("Стоимость доставки: " + FormatMoney(deliveryCost) + " руб.");
            Console.WriteLine("Итого к оплате: " + FormatMoney(total) + " руб.");
        }
        static string FormatMoney(double value)
        {
            return value == Math.Round(value)
                ? value.ToString("0")
                : value.ToString("0.00");
        }

    }
}

