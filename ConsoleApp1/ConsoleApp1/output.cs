using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class output
    {
        public static void ShowResult(double deliveryCost, double total)
        {
            Console.WriteLine("Стоимость доставки: {0} руб.", deliveryCost);
            Console.WriteLine("Итого к оплате: {0} руб.", total);
        }
    }
}
