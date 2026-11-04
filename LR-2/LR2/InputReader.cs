using System;

namespace LR2
{
    public struct InputReader
    {
        public int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string line = Console.ReadLine();
                int value;
                if (int.TryParse(line, out value))
                {
                    return value;
                }
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }

        public int ReadProductNumber(int count)
        {
            while (true)
            {
                int number = ReadInt("Введите номер товара (0 — конец заказа): ");
                if (number >= 0 && number <= count)
                {
                    return number;
                }
                Console.WriteLine("Ошибка: номер товара должен быть от 1 до " + count + ".");
            }
        }

        public int ReadQuantity()
        {
            while (true)
            {
                int quantity = ReadInt("Введите количество: ");
                if (quantity >= 0)
                {
                    return quantity;
                }
                Console.WriteLine("Ошибка: количество не может быть меньше нуля.");
            }
        }

        public int[] ReadOrder(int count)
        {
            int[] ordered = new int[count];
            while (true)
            {
                int number = ReadProductNumber(count);
                if (number == 0)
                {
                    return ordered;
                }
                ordered[number - 1] += ReadQuantity();
            }
        }
    }
}
