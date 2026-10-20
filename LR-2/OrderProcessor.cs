using System;
using System.Collections.Generic;

namespace LR_2
{
    struct OrderProcessor
    {
        public string MissingName;

        public bool TryPlaceOrder(List<Product> products, int[] ordered, out int total)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (ordered[i] > products[i].Stock)
                {
                    MissingName = products[i].Name;
                    total = 0;
                    return false;
                }
            }

            total = 0;
            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                p.Stock -= ordered[i];
                products[i] = p;
                total += ordered[i] * products[i].Price;
            }

            MissingName = null;
            return true;
        }
    }
}