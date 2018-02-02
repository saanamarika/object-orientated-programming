using System;

namespace TransportationClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Transportation Trans1 = new Transportation("Pyörä", "Jopo", "2010", 400);
            Console.WriteLine(Trans1.TransporterInfo());

            CarClass Trans2 = new CarClass("Auto", "Ford Focus", "2006", 13000, "V2", "BKV", 5);
            //Console.WriteLine(Trans2.TransporterInfo());
            Console.WriteLine(Trans2.ToString());

            Trans1.Equals(Trans2);

            Console.ReadKey();
        }
    }
}
