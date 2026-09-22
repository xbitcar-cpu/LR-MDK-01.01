using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cafe = new Dictionary<string, int>()
            {
                {"12:00", 10 },
                {"13:00", 15 },
                {"14:00", 13 },
                {"15:00", 19 },
                {"16:00", 8 },
            };
            int max = 0;
            int min = 99999999;
            string maxhours = "";
            string minhours = "";
            foreach (string key in cafe.Keys)
            {
                int value = cafe[key];
                if (value >= max)
                {
                    max = value;
                    maxhours = key;
                }
                if (value <= min)
                {
                    min = value;
                    minhours = key;
                }
            }
            Console.WriteLine($"максимум {max} человек в {maxhours}, минимум {min} человек в {minhours}");
        }
    }
}
