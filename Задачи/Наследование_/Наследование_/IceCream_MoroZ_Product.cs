using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_
{
    class IceCream_MoroZ_Product : Product
    {
        public override double CalculateDiscount()
        {
            if (count_ > 10)
            {
                return 25;
            }
            if (count_ >= 5)
            {
                return 15;
            }
            return 0;
        }
    }
}
