using System;
using System.Collections.Generic;
using System.Text;

namespace BookClass
{
    class Books
    {
        //Fields
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constructor
        public Books()
        {
            Title = "unknown";
            Author = "unknown";
            Id = 0;
            Price = 0;
        }
        public Books(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }
        //Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Kirja: {Title}\nKirjailija: {Author}\nId: {Id}\nHinta: {Price}\n");
        }
        //Tässä on se vertailu mikä vain kutsutaan pääohjelmassa
        public string BookPrices(Books books)
        {

            if (this.Price < books.Price)
                return ($"Kirja {this.Title} on edullisempi kuin {books.Title}\n");
            return ($"Kirja {this.Title} on kalliimpi kuin {books.Title}\n");
        }

    }
}
