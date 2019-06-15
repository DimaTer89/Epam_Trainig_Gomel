using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Purchase[] purchaseses = new Purchase[]
            {
                new Purchase("breed",20,5),
                new Purchase("meat",120,3),
                new PurchaseDiscount ("milk",30,7),
                new PurchaseDiscount("juice",50,10),
                new DiscountCountPurchase("bananas",30,20),
                new DiscountCountPurchase("apple",25,10)
            };
            Purchase maxPurchase = purchaseses[0];
            bool flag = true;
            for(int i=0;i<purchaseses.Length;i++)
            {
                Console.WriteLine(purchaseses[i]);
                if(purchaseses[i].GetCoast()>maxPurchase.GetCoast())
                {
                    maxPurchase = purchaseses[i];
                }
                if (i!=0&&flag)
                {
                    if(!purchaseses[0].Equals(purchaseses[i]))
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine("\nMaximum Purchase:\nProduct Name={0}\nAmount={1}\n",maxPurchase.ProductName,maxPurchase.GetCoast());
            Console.WriteLine((flag)?"Yes":"No");
            Console.ReadKey();
        }
    }
}
