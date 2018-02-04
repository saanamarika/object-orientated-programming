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

            CarClass Trans2 = new CarClass("Auto", "Ford Focus", "2006", 13000, "2,5L", "R5", 5);
            //Console.WriteLine(Trans2.TransporterInfo());
            Console.WriteLine(Trans2.ToString());
            CarClass Trans3 = new CarClass("Auto", "BMW X5", "2017", 65000, "4,8L", "V8", 3);
            Console.WriteLine(Trans3.ToString());

            Console.WriteLine($"Onko {Trans2.Model} halvempi kuin {Trans3.Model}? Vastaus: {Trans2.Equals(Trans3)}\n");

            LorryClass1 Trans4 = new LorryClass1("Kuorma-auto", "sisu", "2007", 250000, "11L", "V8", 2, 76000, 0.1);
            Console.WriteLine(Trans4.TransporterInfo());
            //Console.WriteLine(Trans4.CountCons());

            Console.ReadKey();
        }
    }
}
