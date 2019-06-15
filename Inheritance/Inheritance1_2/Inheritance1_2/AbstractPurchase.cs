using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_2
{
    abstract class AbstractPurchase : IComparable<AbstractPurchase>
    {
        Commodity commodity;
        int countCommodity;
        public AbstractPurchase()
        {
            commodity = null;
            countCommodity = 0;
        }
        public AbstractPurchase(Commodity commodity,int countCommodity)
        {
            this.commodity = commodity;
            this.countCommodity = countCommodity;
        }
        public Commodity Commodity
        {
            get => commodity;
            private set => commodity = value;
        }
        public int CountCommodity
        {
            get => countCommodity;
            private set => countCommodity = value;
        }
        abstract public decimal GetCoast();
        public override string ToString()
        {
            return (String.Format("{0};{1}",commodity,GetCoast()));
        }
        public int CompareTo(AbstractPurchase other)
        {
            return ((this==null)?1:(other==null)?-1:(this==null&&other==null)?0:this.GetCoast()>other.GetCoast()?-1:1);
        }
    }
}
