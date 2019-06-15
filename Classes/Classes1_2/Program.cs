using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HomogeneousObject wire = new HomogeneousObject("wire", new Material("steel", 7850), 0.03);
            Console.WriteLine(wire);
            wire.Material = new Material("cooper", 8500);
            Console.WriteLine("New mass="+wire.GetMass());
            Console.ReadKey();
        }
    }
}
