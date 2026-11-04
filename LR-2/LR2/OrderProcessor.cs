using System.Collections.Generic;

namespace LR2
{
    public struct OrderProcessor
    {
        private string missingName_;

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

        public bool TryPlaceOrder(List<Product> products, int[] ordered, out int total)
        {
            total = 0;
            missingName_ = null;

            int missing = FindMissingProduct(products, ordered);
            if (missing >= 0)
            {
                missingName_ = products[missing].Name_;
                return false;
            }

            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];
                product.Stock_ -= ordered[i];
                products[i] = product;
                total += ordered[i] * product.Price_;
            }
            return true;
        }

        public string GetMissingName()
        {
            return missingName_;
        }
    }
}
