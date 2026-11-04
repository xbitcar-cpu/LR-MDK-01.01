using System.Collections.Generic;

namespace LR2
{
    public struct OrderProcessor
    {
        public int FindMissingProduct(List<Product> products, int[] ordered)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (ordered[i] > products[i].Stock_)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
