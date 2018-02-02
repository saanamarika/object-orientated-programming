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

        // 3. Muuta Kulku Väline-luokka abstraktiksi ja tee tarvittavat muutokset, jotta sen periytyminen onnistuisi.

        // 4. Kehitä edelleen ohjelmaasi siten, että luot KuormaAuto-luokan, joka perii Auto-luokan.Määrittele luokalle 
        // seuraavat kentät: kuormanPaino ja kulutusPerKg.Määrittele luokalle LaskeKulutus(), joka laskee polttoaineen 
        // kulutuksen ja palauttaa sen.Luo Main()metodissa myös KuormaAuto-olioita ja suorita tyyppimuunnokset Auto- ja 
        // KuormaAuto-olioiden välillä,
    }
}
