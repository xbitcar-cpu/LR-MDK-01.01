using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[]args)
        {
            Person person1 = new Person();
            person1.Name = "Алексей";
            person1.Age = 30;
            Person person2 = new Person("Мария", 25);

            Console.WriteLine(person1);
            Console.WriteLine(person2);

            Console.ReadKey();
        }
    }
}
