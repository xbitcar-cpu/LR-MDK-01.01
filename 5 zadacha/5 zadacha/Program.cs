using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _5_zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 цифры");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
                int max= a;
            if(b> max)
            {
                max = b;
            }
            if (c > max) 
            {
                c = max;
            }
            Console.WriteLine("Максимальное число");
            Console.WriteLine(max);
            
       }
    }
}
