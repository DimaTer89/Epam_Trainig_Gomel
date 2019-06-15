using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_2
{
    class DiscountAbstractPurchase : AbstractPurchase
    {
        const decimal discountPrice = 15;
        public DiscountAbstractPurchase():base()
        {

        }
        public DiscountAbstractPurchase(Commodity commodity,int countCommodity):base(commodity,countCommodity)
        {

        }
        public override decimal GetCoast()
        {
            return ((Commodity.Price-discountPrice)*CountCommodity);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
