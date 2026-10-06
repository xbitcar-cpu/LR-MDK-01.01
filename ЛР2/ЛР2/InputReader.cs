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

      
    }
}
