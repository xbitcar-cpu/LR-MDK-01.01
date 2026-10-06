using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    internal class OrderProcessor
    {
        public static string MissingName { get; private set; }

        public static bool TryPlaceOrder(List<string> names, List<int> prices,
                                         List<int> stock, int[] ordered, out int total)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (ordered[i] > stock[i])
                {
                    MissingName = names[i];
                    total = 0;
                    return false;
                }
            }
            total = 0;
            for (int i = 0; i < names.Count; i++)
            {
                stock[i] -= ordered[i];
                total += ordered[i] * prices[i];
            }
            MissingName = null;
            return true;
        }
    }
}
