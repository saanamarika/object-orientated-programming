using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    class Car
    {
        //Fields
        public string Brand;
        public int Speed;
        //Constructions
        public Car()
        {
            Brand = "";
            Speed = 0;
        }
        //methods
        public void AskData()
        {
            Console.WriteLine("Syötä autosi merkki ja nopeus km/h:");
            Brand = Console.ReadLine();
            Speed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Merkki: {Brand}\nNopeus: {Speed}");
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Annoit autosi merkiksi {Brand} ja nopeudeksi {Speed}km/h\n");
        }
        public void Accelerate()
        {
            double Speed1 =Speed* 1.5;
            Console.WriteLine($"Autosi parannettu nopeus olisi: {Speed1}\n");
        }
        public void Brake()
        {
            double Speed2 = Speed * 0.9;
            Console.WriteLine($"Autosi hidastettu nopeus olisi: {Speed2}\n");
        }

    }
}
