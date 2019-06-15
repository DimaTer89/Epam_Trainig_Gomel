using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_2
{
    class TransportAbstractPurchase : AbstractPurchase
    {
        const decimal transportPrice = 200;
        public TransportAbstractPurchase():base()
        {

        }
        public TransportAbstractPurchase(Commodity commodity,int countCommodity):base(commodity,countCommodity)
        {

        }
        public override decimal GetCoast()
        {
            return (Commodity.Price*CountCommodity+transportPrice);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
