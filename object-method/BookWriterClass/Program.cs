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

            BookClass2 book2 = new BookClass2("Haisuli", "Muumipeikko", "Tiivitaavi", 30.95, "Lapsi");
            book2.GetBook("Olio");

            Console.ReadKey();
        }
    }
}
