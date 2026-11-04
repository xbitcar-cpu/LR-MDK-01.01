using System;
using System.Globalization;

namespace LR1
{
    internal class Program
    {
        const double FreeDeliveryFrom = 2000;
        const double BaseCost = 150;
        const double BaseDistance = 3;
        const double CostPerKm = 50;
        const double PeakMultiplier = 1.3;

        static void Main(string[] args)
        {
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
    }
}
