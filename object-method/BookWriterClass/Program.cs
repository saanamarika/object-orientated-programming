using System;

namespace BookWriterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BookClass2 book = new BookClass2("Olio", "Olli Ollikainen", "Otava", 29.90, "Oksennus");
            book.GetBook("Olio");
            Console.WriteLine(book.Name);
             
            //Kommentoin ylimääräiset testit, jotta ei näy enään ohjelmassa

            //BookClass2 book2 = new BookClass2("Haisuli", "Muumipeikko", "Tiivitaavi", 30.95, "Lapsi");
            //book2.GetBook("Haisuli");

            //BookClass2 book3 = new BookClass2("Koodari", "Jouni", "Saimia", 49.90, "Tietsikka");

            //book3.GetBook("Koodari");

            BookClass2.ChangeTheme("Kauhu");
            //seuraavissa testattu teeman vaihto
            book.GetBook("Olio");
            //book2.GetBook("Haisuli");
            //Seuraavaksi testattu author-luokan toimintaa
            Author kirjailija = new Author("Pekka", "19.7.1989", book);
            kirjailija.AuthorInfo();
            Console.ReadKey();
        }
    }
}
