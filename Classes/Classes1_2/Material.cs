using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1_2
{
    class Material
    {
        public readonly string Name;
        public readonly double Density;
        public Material()
        {
            Name = null;
            Density = 0;
        }
        public Material(string name,double density)
        {
            Name = name;
            Density = density;
        }
        public override string ToString()
        {
            return (String.Format("{0};{1}", Name, Density));
        }
    }
}
