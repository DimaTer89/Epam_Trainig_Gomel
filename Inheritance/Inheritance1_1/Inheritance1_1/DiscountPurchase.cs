using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_1
{
    class PurchaseDiscount:Purchase
    {
        public const decimal Discount = 15;
        public PurchaseDiscount():base()
        {
            
        }
        public PurchaseDiscount(string nameProduct,decimal price,int countProduct):base(nameProduct,price,countProduct)
        {
           
        }
        public override decimal GetCoast()
        {
            return ((Price-Discount)*QuatityGoods);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
