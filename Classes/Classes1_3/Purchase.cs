using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1_3
{
    class Purchase:IComparable<Purchase>
    {
        string nameProduct;
        decimal price;
        int countProduct;
        Days day;
        public Purchase()
        {
            nameProduct = null;
            price = 0;
            countProduct = 0;
            day = 0;
        }
        public Purchase(string name,decimal price,int count,Days day)
        {
            nameProduct = name;
            this.price = price;
            countProduct = count;
            this.day = day;
        }
        public string NameProduct
        {
            get => nameProduct;
            set => nameProduct = value;
        }
        public decimal Price
        {
            get => price;
            set => price = value;
        }
        public int CountProduct
        {
            get => countProduct;
            set => countProduct = value;
        }
        public Days Day
        {
            get => day;
            set => day = value;
        }

        public int CompareTo(Purchase other)
        {
            return (this == null ? -1 : other == null ? 1 : (this == null && other == null)?0:GetCoast()>other.GetCoast()?1:-1);
        }

        public decimal GetCoast()
        {
            return (price * countProduct);
        }
        public override string ToString()
        {
            return (String.Format("{0};{1};{2};{3};{4}", nameProduct, price, countProduct, day, GetCoast()));
        }
    }
}
