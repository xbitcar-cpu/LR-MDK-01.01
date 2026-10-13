using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        private int id_;
        private string name_;
        private ProductGroup group_;
        private decimal salePrise_;
        private string material_;
        private string size_;
        private string brand_;


        public Product(int id, string name, ProductGroup group, decimal salePrise, string material, string size, string brand)
        {
            id_ = id;
            name_ = name;
            group_ = group;
            salePrise_ = salePrise;
            material_ = material;
            size_ = size;
            brand_ = brand;
        }
        public int getId() { return id_; }
        public string getName() { return name_; }
        public ProductGroup getGroup() { return group_;}
        public decimal getSalePrise() {  return salePrise_; }
        public string getMaterial() { return material_; }
        public string getSize() { return size_; }
        public string getBrand() { return brand_;}
    }
}
