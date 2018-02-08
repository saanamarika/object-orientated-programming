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
        public override string CarInfo()
        {
            return $"Kulkuväline: {Type}\n" +
                $"Malli: {Model}\n" +
                $"Vuosimalli: {Year}\n" +
                $"Hinta: {Price:c2}\n" +
                $"Moottorin koko: {Engine}\n" +
                $"Moottorin malli: {Model2}\n" +
                $"Ovien lkm: {Doors}\n" +
                $"Paino: {Weight}\n"+
                $"Kulutus per/kg: {PerKg}\n"+
                $"Polttoaineen kulutus/km: {CountCons()}\n"+
                $"--------------------\n";
        }
        private double CountCons()
        {
            return Weight * PerKg;
        }


        // 4. Kehitä edelleen ohjelmaasi siten, että luot KuormaAuto-luokan, joka perii Auto-luokan.Määrittele luokalle 
        // seuraavat kentät: kuormanPaino ja kulutusPerKg.Määrittele luokalle LaskeKulutus(), joka laskee polttoaineen 
        // kulutuksen ja palauttaa sen.Luo Main()metodissa myös KuormaAuto-olioita ja suorita tyyppimuunnokset Auto- ja 
        // KuormaAuto-olioiden välillä,
    }
}
