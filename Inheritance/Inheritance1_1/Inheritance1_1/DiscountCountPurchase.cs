using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_1
{
    class DiscountCountPurchase:Purchase
    {
        const int discountCount = 10;
        const int discount = 30;
        public DiscountCountPurchase():base()
        {
            
        }
        public DiscountCountPurchase(string nameProduct,decimal price,int countProduct):base(nameProduct,price,countProduct)
        {
            
        }
        public override decimal GetCoast()
        {
            return ((QuatityGoods <= discountCount) ? Price * QuatityGoods : (Price * QuatityGoods*(decimal)(1-discount/100.0)));
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
