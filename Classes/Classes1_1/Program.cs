using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelExpenses[] travelExpenses = new TravelExpenses[]
            {
                new TravelExpenses("Anton Slutsky", 5000, 5),
                new TravelExpenses("Evgeniy Voyloshnokov",7000,10),
                null,
                new TravelExpenses("Aleksandr Losev",3000,4),
                new TravelExpenses()
            };
            for (int i = 0; i < travelExpenses.Length; i++)
            {
                if(travelExpenses[i]!=null)
                    travelExpenses[i].Show();
                Console.WriteLine("=============");
            }
            travelExpenses[travelExpenses.Length - 1].Transport = 10000;
            Console.WriteLine("Duration="+(travelExpenses[0].Days+travelExpenses[1].Days));
            Console.WriteLine("=================");
            foreach (TravelExpenses item in travelExpenses)
                  Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
