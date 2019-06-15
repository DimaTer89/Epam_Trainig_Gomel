using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_1
{
    class Purchase
    {
        string productName;
        decimal price;
        int quantityGoods;
        public Purchase()
        {
            productName = null;
            price = 0;
            quantityGoods = 0;
        }
        public Purchase(string productName, decimal price,int countGoods)
        {
            this.productName = productName;
            this.price = price;
            quantityGoods = countGoods;
        }
        public string ProductName
        {
            get => productName;
            private set => productName = value;
        }
        public decimal Price
        {
            get => price;
            private set => price = value;
        }
        public int QuatityGoods
        {
            get => quantityGoods;
            private set => quantityGoods = value;
        }
        public virtual decimal GetCoast()
        {
            return (price * quantityGoods);
        }
        public override string ToString()
        {
            return (String.Format("{0};{1};{2};{3}", productName, price, quantityGoods, GetCoast()));
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Purchase purchase = obj as Purchase;
            if (purchase == null)
                return false;
            return (this.ProductName == purchase.ProductName && this.Price == purchase.Price);
        }
        public override int GetHashCode()
        {
            int hash = ProductName.GetHashCode() + Price.GetHashCode();
            return hash.GetHashCode();
        }
    }
}
