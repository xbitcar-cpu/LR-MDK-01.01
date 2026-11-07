using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class CandyProduct : Product
    {
            
        public override double CalculateDiscount()
        {
            if (count_ > 300)
            {
                return 50;
            }
            if(count_ > 150)
            {
                return 30;
            }
            if (count_ >= 20)
            {
                return 10;
            }
            return 0;
        }
    }
}
