using System;
using System.Collections.Generic;
using System.Text;

namespace Literature
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
        public virtual void GetBook(string bookName)
        {
            if (Name == bookName)
                Console.WriteLine ($"Kirja {bookName} löytyi!\n" +
                    $"Kirjan nimi: {Name}\n" +
                    $"Kirjailija: {Author}\n" +
                    $"Julkaisija: {Publisher}\n" +
                    $"Hinta: {Price:c2}\n" +
                    $"Teema: {_themeName}\n" +
                    $"---------------------\n");
            else
               Console.WriteLine ($"Kirjaa {bookName} ei löytynyt.\n");
        }
        public static void ChangeTheme(string newThemeName)
        {
            _themeName = newThemeName;
        }
        public void BookInfo()
        {
            Console.WriteLine($"\n" +
             $"Kirjan nimi: {Name}\n" +
             $"Kirjailija: {Author}\n" +
             $"Julkaisija: {Publisher}\n" +
             $"Hinta: {Price:c2}\n" +
             $"Teema: {_themeName}\n" +
             $"---------------------\n");
        }


        //Muokkaa edellisen tehtävän ratkaisua siten, että määrittelet Kirjallisuus-nimiavaruuden ja laitat Kirja-luokan 
        //sen sisälle.Muokkaa ohjelmaa siten, että se taas toimii oikein.
    }
}
