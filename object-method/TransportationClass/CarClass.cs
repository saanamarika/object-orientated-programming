using System;
using System.Collections.Generic;
using System.Text;

namespace TransportationClass
{
    class CarClass : Transportation
    {
        public string Engine;
        public string Model2;
        public int Doors;


        public CarClass(string type, string model, string year, double price, string engine, string model2, int doors) : base(type, model, year, price)
        {
            Engine = engine;
            Model2 = model2;
            Doors = doors;
        }

        public CarClass(string type, string model, string year, double price) : base(type, model, year, price)
        {
        }

        //public override string TransporterInfo()
        //{
        //    return $"Kulkuväline: {Type}\n" +
        //        $"Malli: {Model}\n" +
        //        $"Vuosimalli: {Year}\n" +
        //        $"Hinta: {Price:c2}\n";
        //}
        public virtual string CarInfo()
        {
            return $"Kulkuväline: {Type}\n" +
                $"Malli: {Model}\n" +
                $"Vuosimalli: {Year}\n" +
                $"Hinta: {Price:c2}\n" +
                $"Moottorin koko: {Engine}\n" +
                $"Moottorin malli: {Model2}\n" +
                $"Ovien lkm: {Doors}\n" +
                $"--------------------\n";        
        }

    public override string ToString()
        {
            return TransporterInfo();
        }

        public override bool Equals(object obj)
        {
            if (Price < ((CarClass)obj).Price)
                return true;
            else
                return false;

        }



        // Määrittele myös Auto-luokka, joka perii KulkuVäline-luokan.
        // Auto-luokan protected-kenttien tulee olla koneenKoko, malli ja ovienLkm.Määrittele Auto-luokalle myös 
        // omat muodostimet sekä ylikirjoita TulostaTiedot()-metodi siten, että se tulostaa auton tiedot.
        // Luo pääohjelmassa KulkuVäline- ja Auto-luokista olioita ja kutsu niiden metodit. 

        // 2. Muokkaa edellisen tehtävän ratkaisua siten, että Auto-luokassa ylikirjoitat System.Object-luokasta 
        // periytyvät ToString()- ja Equals(obj, obj}-metodit.Luo Main()-metodissa olioita Auto-luokasta ja kutsu 
        // niiden ToString()- ja Equals(obj, obj)-metodit.
    }
}
