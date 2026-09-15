using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class decision
    {
        public static double GetDeliveryCost(double orderCost, double distance, int time)
        {
            if (orderCost >= 2000)
                return 0;

            double baseCost;
            if (distance <= 3)
                baseCost = 150;
            else
                baseCost = 150 + (distance - 3) * 50;

            double surcharge;
            if ((time >= 12 && time < 14) || (time >= 18 && time < 20))
                surcharge = 1.3;
            else
                surcharge = 1.0;

            return baseCost * surcharge;
        }

        public static double GetTotal(double orderCost, double deliveryCost)
        {
            return orderCost + deliveryCost;
        }

    }
}
