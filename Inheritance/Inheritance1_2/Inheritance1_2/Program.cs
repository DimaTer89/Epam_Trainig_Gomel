using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1_2
{
    class Program
    {
        private static void Show(AbstractPurchase[] purchasies)
        {
            for(int i=0;i<purchasies.Length;i++)
            {
                Console.WriteLine(purchasies[i]);
            }
        }
        static void Main(string[] args)
        {
            AbstractPurchase[] purchasies = new AbstractPurchase[]
            {
                new DiscountAbstractPurchase(new Commodity("meat",120),3),
                new DiscountAbstractPurchase(new Commodity("milk",30),7),
                new DiscountCountAbstractPurchase(new Commodity("juice",50),10),
                new DiscountCountAbstractPurchase(new Commodity("bananas",30),20),
                new TransportAbstractPurchase(new Commodity("apple",25),10),
                new TransportAbstractPurchase(new Commodity("breed",15),10)
            };
            Show(purchasies);
            Console.WriteLine("================");
            Array.Sort(purchasies);
            Show(purchasies);
            Console.ReadKey();
        }
    }
}


