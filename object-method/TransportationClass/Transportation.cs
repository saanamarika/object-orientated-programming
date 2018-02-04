using System;
using System.Collections.Generic;
using System.Text;

namespace TransportationClass
{
    class Transportation
    {
        public string Type;
        public string Model;
        public string Year;
        public double Price;

        public Transportation(string type, string model, string year, double price)
        {
            Type = type;
            Model = model;
            Year = year;
            Price = price;
        }
        public virtual string TransporterInfo()
        {
            return $"Kulkuneuvo: {Type}\n" +
                $"Malli: {Model}\n" +
                $"Vuosimalli: {Year}\n" +
                $"Hinta: {Price:c2}\n" +
                $"-----------------------\n";
        }
        public override bool Equals(object obj)
        {
            if (Price < ((Transportation)obj).Price)
                return true;
            else
                return false;

        }

        // 3. Muuta Kulku Väline-luokka abstraktiksi ja tee tarvittavat muutokset, jotta sen periytyminen onnistuisi.


    }
}
