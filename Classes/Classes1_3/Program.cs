using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Purchase[] products = new Purchase[]
            {
                new Purchase("bread",50,5,Days.Monday),
                new Purchase("milk",150,3,Days.Friday),
                new Purchase("meat",350,7,Days.Tuesday),
                new Purchase("laptop",1450,1,Days.Wednesday),
                new Purchase("fridge",750,2,Days.Sunday)
            };
            for(int i=0;i<products.Length;i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.WriteLine("==============");
            Console.WriteLine("Average Price={0}\nPurchase day={1}",AvveragePrice(products),MaxPriceDay(products));
            Console.WriteLine("==============");
            Array.Sort(products);
            for(int i=0;i<products.Length;i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.ReadKey();
        }
        static decimal AvveragePrice(Purchase[] products)
        {
            decimal averagePrice = 0;
            for(int i=0;i<products.Length;i++)
            {
                averagePrice += products[i].GetCoast();
            }
            return (averagePrice / products.Length);
        }
        static string MaxPriceDay(Purchase[] products)
        {
            Days day = products[0].Day;
            decimal maxCoast = products[0].GetCoast();
            for(int i=0;i<products.Length;i++)
            {
                if(maxCoast<products[i].GetCoast())
                {
                    maxCoast = products[i].GetCoast();
                    day = products[i].Day;
                }
            }
            return day.ToString();
        }
    }
}
