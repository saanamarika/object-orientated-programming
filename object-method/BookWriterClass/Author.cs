using System;
using System.Collections.Generic;
using System.Text;
using Literature;

namespace BookWriterClass
{
    //harjoituksen vuoksi muutin tämänkin periytyväksi, koska häiritsi, että kirjailija oli eri kuin mitä tähän tuli.
    class Author : BookClass2
    {
        public string Author2;
        public string Birthday;

        public Author(string name, string author, string publisher, double price, string themename, string author2, string birthday) : base(name, author, publisher, price, themename)
        {
            Author2 = author2;
            Birthday = birthday;
        }

        public override void GetBook(string bookName)
        {
            if (Name == bookName)
                Console.WriteLine($"Kirja {bookName} löytyi!\n" +
                    $"Kirjan nimi: {Name}\n" +
                    $"Kirjailija: {Author2}\n" +
                    $"Syntynyt: {Birthday}\n" +
                    $"Julkaisija: {Publisher}\n" +
                    $"Hinta: {Price:c2}\n" +
                    $"Teema: {ThemeName}\n" +
                    $"---------------------\n");
            else
                Console.WriteLine($"Kirjaa {bookName} ei löytynyt.\n");
        }




        //4. Ohjelma, jossa määrittelet Kirjailija-luokan.Kirjailija-luokan kentät ovat string-tyyppiset nimi ja 
        //syntymäpäivä sekä kirja, jonka tietotyyppi on edellisessä tehtävässä määrittelemäsi Kirja-luokka.
        //Määrittele luokalle sopivat muodostimet sekä TulostaTiedot()-metodi, joka tulostaa kirjailijan tiedot. 
        //(Muista, että kirjailijan tiedot sisältävät myös kirjan tiedot.Luo Main()-metodissa olioita Kirjailija-luokasta 
        //ja kutsu TulostaTiedot()-metodi.

    }
}
