using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_2
{
    class Commodity
    {
        string nameProduct;
        decimal price;
        public Commodity()
        {
            nameProduct = null;
            price = 0;
        }
        public Commodity(string nameProduct,decimal price)
        {
            this.nameProduct = nameProduct;
            this.price = price;
        }
        public string NameProduct
        {
            get => nameProduct;
            private set => nameProduct = value;
        }
        public decimal Price
        {
            get => price;
            private set => price = value;
        }
        public override string ToString()
        {
            return (String.Format("{0};{1}",nameProduct,price));
        }
    }
}
