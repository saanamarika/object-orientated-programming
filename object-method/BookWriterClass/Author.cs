using System;
using System.Collections.Generic;
using System.Text;

namespace BookWriterClass
{
    class Author
    {
        public string Author2;
        public string Birthday;
        public BookClass2 Bc2;

        public Author()
        {
            Author2 = "";
            Birthday = "";
            Bc2 = new BookClass2();
        }

        public Author(string author2, string birthday, BookClass2 book)
        {
            Author2 = author2;
            Birthday = birthday;
            Bc2 = book;
        }
        public void AuthorInfo()
        {
            Console.Write($"Kirjailija: {Author2}\n" +
                $"Syntymäpäivä: {Birthday}\n" +
                $"Kirjoittanut kirjan: ");
            Bc2.BookInfo();
        }



        //4. Ohjelma, jossa määrittelet Kirjailija-luokan.Kirjailija-luokan kentät ovat string-tyyppiset nimi ja 
        //syntymäpäivä sekä kirja, jonka tietotyyppi on edellisessä tehtävässä määrittelemäsi Kirja-luokka.
        //Määrittele luokalle sopivat muodostimet sekä TulostaTiedot()-metodi, joka tulostaa kirjailijan tiedot. 
        //(Muista, että kirjailijan tiedot sisältävät myös kirjan tiedot.Luo Main()-metodissa olioita Kirjailija-luokasta 
        //ja kutsu TulostaTiedot()-metodi.

    }
}
