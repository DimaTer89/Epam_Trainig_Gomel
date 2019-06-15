using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1_2
{
    class HomogeneousObject
    {
        string nameObject;
        Material material;
        double volume;
        public HomogeneousObject()
        {
            nameObject = null;
            material = null;
            volume = 0;
        }
        public HomogeneousObject(string name,Material material,double volume)
        {
            nameObject = name;
            this.material = material;
            this.volume = volume;
        }
        public string NameObject
        {
            get => nameObject;
            set => nameObject = value;
        }
        public Material Material
        {
            get => material;
            set => material = value;
        }
        public double Volume
        {
            get => volume;
            set => volume = value;
        }
        public double GetMass()
        {
            return (volume * material.Density);
        }
        public override string ToString()
        {
            return (String.Format("{0};{1};{2};{3}", nameObject, material, volume,GetMass()));
        }
    }
}
