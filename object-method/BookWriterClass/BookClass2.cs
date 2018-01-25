using System;
using System.Collections.Generic;
using System.Text;

namespace BookWriterClass
{
    class BookClass2
    {
        public string Name;
        public string Author;
        public string Publisher;
        public double Price;
        public static string ThemeName;


        public BookClass2()
        {
            Name = "";
            Author = "";
            Publisher = "";
            Price = 0;
            ThemeName = "";
        }
        public BookClass2(string name, string author, string publisher, double price, string themename)
        {
            Name = name;
            Author = author;
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
                    $"Hinta: {Price}\n" +
                    $"---------------------\n");
            else
                Console.WriteLine($"Kirjaa {bookName} ei löytynyt.");
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



        //4. Ohjelma, jossa määrittelet Kirjailija-luokan.Kirjailija-luokan kentät ovat string-tyyppiset nimi ja 
        //syntymäpäivä sekä kirja, jonka tietotyyppi on edellisessä tehtävässä määrittelemäsi Kirja-luokka.
        //Määrittele luokalle sopivat muodostimet sekä TulostaTiedot()-metodi, joka tulostaa kirjailijan tiedot. 
        //(Muista, että kirjailijan tiedot sisältävät myös kirjan tiedot.Luo Main()-metodissa olioita Kirjailija-luokasta 
        //ja kutsu TulostaTiedot()-metodi.



        //Muokkaa edellisen tehtävän ratkaisua siten, että määrittelet Kirjallisuus-nimiavaruuden ja laitat Kirja-luokan 
        //sen sisälle.Muokkaa ohjelmaa siten, että se taas toimii oikein.
    }
}
