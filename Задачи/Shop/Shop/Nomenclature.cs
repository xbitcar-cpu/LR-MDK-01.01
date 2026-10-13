using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Nomenclature
    {
        private Dictionary<int, Product> products_;
        public Nomenclature()
        {
            products_ = new Dictionary<int ,Product>();
        }
        public void Add (Product product)
        {
            products_[product.getId()] = product;
        }
        public void Remove(int id)
        {
            products_.Remove(id);
        }
        public Product FindId(int id)
        {
            return products_[id];
        }
        
    }
}
