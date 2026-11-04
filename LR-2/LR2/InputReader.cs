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
    }
}
