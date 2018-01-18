using System;

namespace FirmClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Firm firm = new Firm("Kala", "Kalankatu 15", "045 1234 123", 2100000, 500000);
            firm.printInfo();
            firm.howIsGoing();

            Firm firm2 = new Firm("Hauki", "Järvikatu 23", "023 2345", 230500, 95300);
            firm2.printInfo();
            firm2.howIsGoing();

            Firm firm3 = new Firm(firm2);
            firm3.printInfo();
            firm3.howIsGoing();

            Console.ReadKey();
        }
    }
}
