using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double orderCost = Input.ReadOrderCost();
                double distance = Input.ReadDistance();
                int time = Input.ReadTime();

                double deliveryCost = decision.GetDeliveryCost(orderCost, distance, time);
                double total = decision.GetTotal(orderCost, deliveryCost);

                output.ShowResult(deliveryCost, total);
            }


        }
    }
}
