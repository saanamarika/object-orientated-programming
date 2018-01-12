using System;

namespace BookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Books newBook = new Books();
            newBook.Title = "Kadonneen koodin arvoitus";
            newBook.Author = "Mäntti Mänttinen";
            newBook.Id = 1234567;
            newBook.Price = 39.95;
            newBook.PrintInfo();

            Books newBook2 = new Books("Koodaus one ou one", "Saanis Sieppaus", 1234, 12.95);
            newBook2.PrintInfo();

            Books book = new Books("Digimonit ja koodin salaisuus", "Pertti Jaakola", 123456, 29.95);
            book.PrintInfo();

            Console.WriteLine(newBook.BookPrices(book));
            Console.WriteLine(newBook2.BookPrices(newBook));
            Console.WriteLine(newBook2.BookPrices(book));

            Console.ReadKey();


        }
    }
}
