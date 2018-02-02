using System;

namespace TransportationClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Transportation Car1 = new Transportation("BMW", "X5", "2010", 22000);
            Car1.CarInfo();

            Console.ReadKey();
        }
    }
}
