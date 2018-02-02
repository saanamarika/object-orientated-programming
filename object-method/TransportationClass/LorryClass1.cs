using System;
using System.Collections.Generic;
using System.Text;

namespace TransportationClass
{
    class LorryClass1:CarClass
    {
        public double Weight;
        public double PerKg;

        public LorryClass1(string type, string model, string year, double price, string engine, string model2, int doors,double weight,double perkg) : base(type, model, year, price, engine, model2, doors)
        {
            Weight = weight;
            PerKg = perkg;
        }

    }
}
