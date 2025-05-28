using System;
namespace comando
{
    public class Knif
    {
        string Name;
        string Metal;
        string Manufacturer;
        string Color;
        double Weight;
        bool Status;
        public Knif(string name,string metal,string manufacturer,string color,double weight,bool status)
        {
            Name = name;
            Metal = metal;
            Manufacturer = manufacturer;
            Color = color;
            Weight = weight;
            Status = status;
        }
    }
}

