using System;
using System.Collections.Generic;
using System.Text;

namespace BookWriterClass
{
    class BookClass2
    {
        private string _name;
        private string _author;
        public string Publisher;
        private double _price;
        private static string _themeName;

        public static string ThemeName { get => _themeName; set => _themeName = value; }
        public string Name
        {
            get => _name;

            //set => _name = value;
        }
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                if (value > 30)
                    _price *= 0.90;
            }
        }

        public string Author { get => _author; }
        //set => _author = value; }

        public BookClass2()
        {
            _name = "";
            _author = "";
            Publisher = "";
            Price = 0;
            ThemeName = "";
        }
        public BookClass2(string name, string author, string publisher, double price, string themename)
        {
            _name = name;
            _author = author;
            Publisher = publisher;
            Price = price;
            ThemeName = themename;
        }
        public void GetBook(string bookName)
        {
            if (Name == bookName)
                Console.WriteLine($"Kirja {Name} löytyi!\n" +
                    $"Kirjan nimi: {Name}\n" +
                    $"Kirjailija: {Author}\n" +
                    $"Julkaisija: {Publisher}\n" +
                    $"Hinta: {Price:c2}\n" +
                    $"Teema: {_themeName}\n" +
                    $"---------------------\n");
            else
                Console.WriteLine($"Kirjaa {bookName} ei löytynyt.");
        }
        public static void ChangeTheme(string newThemeName)
        {
            _themeName = newThemeName;
        }
        public void BookInfo()
        {
            Console.WriteLine($"\n"+
    $"Kirjan nimi: {Name}\n" +
    $"Kirjailija: {Author}\n" +
    $"Julkaisija: {Publisher}\n" +
    $"Hinta: {Price:c2}\n" +
    $"Teema: {_themeName}\n" +
    $"---------------------\n");
        }



        //1. Ohjelma, jossa määrittelet Kirja-luokan.Kirja-luokan kentät ovat nimi, kirjailija, kustantaja,
        //hinta sekä teemanNimi, joka on staattinen kenttä.Määrittele luokalle sopivat muodostimet sekä HaeKirja()- ja 
        //VaihdaTeema()-metodit.HaeKirja()-metodi saa parametrina nimen ja vertailee sitä kirjan nimeen.Metodin tulee 
        //tulostaa kirjan loput tiedot, jos parametrin ja kirjan nimi ovat samat, ja muussa tapauksessa ilmoittaa, 
        //että kirjaa ei löytynyt, VaihdaTeema() on staattinen metodi, jolla muutat teeman nimeä, Luo Main()-metodissa 
        //muutama olio luokasta ja kutsu HaeKirja()- ja VaihdaTeema()-metodit.

        //2. Kehitä edellisen tehtävän ratkaisua siten, että määrittelet Kirja –luokalle Hinta-ominaisuuden.Määrittele 
        //Hinta-ominaisuudelle set –metodi siten, että sillä alustetaan hinta-kenttä, ja jos sen saama arvo on yli 30, 
        //sitä vähennetään 10 %:lla.Määrittele get-metodi siten, että se palauttaa hinta-kentän arvon.Luo Main()-metodissa 
        //olioita Kirja –luokasta sekä alusta ja tulosta Hinta-ominaisuus (property).




        //Vihje: set-metodissa voidaan käyttää: if-lausetta, jossa value on vertailun kohde



        //3.Kehitä edellisen tehtävän ratkaisua siten, että määrittelet Kirja-luokalle Kirjailija-lukuominaisuuden 
        //(readonly property). Luo Main()-metodissa olio Kirja-luokasta ja tulosta sen Kirjailija-ominaisuuden arvo.






        //Muokkaa edellisen tehtävän ratkaisua siten, että määrittelet Kirjallisuus-nimiavaruuden ja laitat Kirja-luokan 
        //sen sisälle.Muokkaa ohjelmaa siten, että se taas toimii oikein.
    }
}
