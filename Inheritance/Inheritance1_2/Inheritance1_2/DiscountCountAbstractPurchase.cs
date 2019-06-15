using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_2
{
    class DiscountCountAbstractPurchase : AbstractPurchase
    {
        const int count = 10;
        const decimal discount = 30;
        public DiscountCountAbstractPurchase():base()
        {

        }
        public DiscountCountAbstractPurchase(Commodity commodity,int countCommodity):base(commodity,countCommodity)
        {

        }
        public override decimal GetCoast()
        {
            return ((CountCommodity<=count)?Commodity.Price*CountCommodity:(Commodity.Price*CountCommodity*(decimal)(1-(discount/100m))));
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
