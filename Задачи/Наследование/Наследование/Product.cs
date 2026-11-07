using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    public class Product
    {
        protected string name_;
        protected double price_;
        protected int count_;

        public void SetName(string name)
        {
            name_ = name;
        }
        public void SetPrice(double price)
        {
            price_ = price;
        }
        public void SetCount(int count)
        {
            count_ = count;
        } 

        public void Set(string name, double price, int count)
        {
            SetName(name);
            SetPrice(price);
            SetCount(count);
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
        public virtual double CalculateDiscount()
        {
            return 0;
        }
    }
}
