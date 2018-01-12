using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Car car = new Car();
            car.AskData();
            car.ShowCarInfo();
            car.Accelerate();
            car.Brake();

            Car car2 = new Car();
            car2.AskData();
            car2.ShowCarInfo();
            car2.Accelerate();
            car2.Brake();

            Console.ReadKey();
        }
    }
}
