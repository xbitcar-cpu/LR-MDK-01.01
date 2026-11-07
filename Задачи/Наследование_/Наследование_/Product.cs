using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_
{
    class Product
    {
        protected string name_;
        protected double price_;
        protected int count_;

        public void Set(string name, double price, int count)
        {
            name_ = name;
            price_ = price;
            count_ = count;
        }

        public string GetName()
        {
            return name_;
        }
        public double GetPrice()
        {
            return price_;
        }
        public int GetCount()
        {
            return count_;
        }
        public virtual int CalculateDiscount()
        {
            return 0;
        }
    }
}
