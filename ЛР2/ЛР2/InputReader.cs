using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    internal class InputReader
    {
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                int value;
                if (int.TryParse(s, out value))
                {
                    return value;
                }
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }

        public static void ReadOrder(int count, int[] ordered)
        {
            while (true)
            {
                int num = ReadInt("Введите номер товара (0 — конец заказа): ");
                if (num == 0) break;

                if (num < 1 || num > count)
                {
                    Console.WriteLine("Ошибка: номер товара должен быть от 1 до " + count + ".");
                    continue;
                }

                int qty = ReadInt("Введите количество: ");
                if (qty < 0)
                {
                    Console.WriteLine("Ошибка: количество не может быть меньше нуля.");
                    continue;
                }

                ordered[num - 1] += qty;
            }
        }
    }
}
