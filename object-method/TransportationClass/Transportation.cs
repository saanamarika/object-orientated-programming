using System;
using System.Collections.Generic;
using System.Text;

namespace TransportationClass
{
    class Transportation
    {
        private string _type;
        private string _model;
        private string _year;
        private double _price;

        public Transportation(string type, string model, string year, double price)
        {
            _type = type;
            _model = model;
            _year = year;
            _price = price;
        }
        public void CarInfo()
        {
            Console.WriteLine($"Auto: {_type}\n" +
                $"Malli: {_model}\n" +
                $"Vuosimalli: {_year}\n" +
                $"Hinta: {_price:c2}\n" +
                $"-----------------------\n");
        }

        // 1. Ohjelma, jossa määrittelet KulkuVäline-luokan, johon kuuluvat seuraavat protected -kentät: tyyppi, 
        // merkki, vuosiMalli ja hinta.Määrittele luokalle sopivat muodostimet sekä virtuaalinen TulostaTiedot()-metodi, 
        // joka tulostaa näytölle KulkuValine-olion tiedot.

        // Määrittele myös Auto-luokka, joka perii KulkuVäline-luokan.
        // Auto-luokan protected-kenttien tulee olla koneenKoko, malli ja ovienLkm.Määrittele Auto-luokalle myös 
        // omat muodostimet sekä ylikirjoita TulostaTiedot()-metodi siten, että se tulostaa auton tiedot.
        // Luo pääohjelmassa KulkuVäline- ja Auto-luokista olioita ja kutsu niiden metodit. 

        // 2. Muokkaa edellisen tehtävän ratkaisua siten, että Auto-luokassa ylikirjoitat System.Object-luokasta 
        // periytyvät ToString()- ja Equals(obj, obj}-metodit.Luo Main()-metodissa olioita Auto-luokasta ja kutsu 
        // niiden ToString()- ja Equals(obj, obj)-metodit.

        // 3. Muuta Kulku Väline-luokka abstraktiksi ja tee tarvittavat muutokset, jotta sen periytyminen onnistuisi.

        // 4. Kehitä edelleen ohjelmaasi siten, että luot KuormaAuto-luokan, joka perii Auto-luokan.Määrittele luokalle 
        // seuraavat kentät: kuormanPaino ja kulutusPerKg.Määrittele luokalle LaskeKulutus(), joka laskee polttoaineen 
        // kulutuksen ja palauttaa sen.Luo Main()metodissa myös KuormaAuto-olioita ja suorita tyyppimuunnokset Auto- ja 
        // KuormaAuto-olioiden välillä,
    }
}
