using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Input
    {
        public static double ReadOrderCost()
        {
            double cost;
            bool isValid;
            do
            {
                Console.Write("Введите стоимость заказа (руб.): ");
                isValid = double.TryParse(Console.ReadLine(), out cost) && cost > 0;
                if (!isValid)
                    Console.WriteLine("Ошибка! Введите число больше нуля.");
            } while (!isValid);
            return cost;
        }
        public static double ReadDistance()
        {
            double distance;
            bool isValid;
            do
            {
                Console.Write("Введите расстояние доставки (км): ");
                isValid = double.TryParse(Console.ReadLine(), out distance) && distance > 0;
                if (!isValid)
                    Console.WriteLine("Ошибка! Введите число больше нуля.");
            } while (!isValid);
            return distance;
        }
        public static int ReadTime()
        {
            int time;
            bool isValid;
            do
            {
                Console.Write("Введите время заказа (час): ");
                isValid = int.TryParse(Console.ReadLine(), out time) && time >= 0 && time <= 23;
                if (!isValid)
                    Console.WriteLine("Ошибка! Введите целое число от 0 до 23.");
            } while (!isValid);
            return time;
        }
    }
}
