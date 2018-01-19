using System;

namespace TicketClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnäyttely");
            Ticket ticket = new Ticket();
            ticket.AskData();
            ticket.CountDiscount();

            Ticket ticket2 = new Ticket("Santeri", 65, "N", "Y", "Y");
            ticket2.PrintUserInfo();
            ticket2.CountDiscount();

            Console.ReadKey();
        }
    }
}
