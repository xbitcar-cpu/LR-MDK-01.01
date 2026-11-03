using System.Collections.Generic;

namespace LR3
{
    public class Nomenclature
    {
        private Dictionary<ProductGroup, List<string>> products_;

        public Nomenclature()
        {
            products_ = new Dictionary<ProductGroup, List<string>>();
            products_.Add(ProductGroup.Balls, new List<string>());
            products_.Add(ProductGroup.Fitness, new List<string>());
            products_.Add(ProductGroup.Protection, new List<string>());
        }

        public List<string> GetAllProductsGroup(ProductGroup productGroup)
        {
            if (products_.ContainsKey(productGroup))
            {
                return products_[productGroup];
            }
            List<string> emptyResult = new List<string>();
            return emptyResult;
        }

        public void AddProduct(ProductGroup productGroup, string productName)
        {
            List<string> products = products_[productGroup];
            products.Add(productName);
        }

        public ProductGroup? GetProductGroupByProduct(string product)
        {
            foreach (KeyValuePair<ProductGroup, List<string>> productGroups
                     in products_)
            {
                ProductGroup group = productGroups.Key;
                List<string> allProducts = productGroups.Value;

                if (allProducts.Contains(product))
                {
                    return group;
                }
            }

            return null;
        }
    }
}
