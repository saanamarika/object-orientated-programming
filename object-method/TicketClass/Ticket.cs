using System;
using System.Collections.Generic;
using System.Text;

namespace TicketClass
{
    class Ticket
    {
        //Fields
        public string User;
        public int Age;
        public string Student;
        public string Army;
        public string Mtk;
        public int Price;
        public int Discount;
        public decimal EndPrice;

        public Ticket()
        {
            User = "";
            Age = 0;
            Student = "";
            Army = "";
            Mtk = "";
            Price = 0;
            Discount = 0;
            EndPrice = 0;
        }
        public Ticket(string user, int age, string student,string army,string mtk)
        {
            User = user;
            Age = age;
            Student = student;
            Army = army;
            Mtk = mtk;
            //Price = price;
        }
        public Ticket(Ticket previousData)
        {
            User = previousData.User;

        }
        public void AskData()
        {
            Console.Write("Nimi: ");
            User = Console.ReadLine();
            Console.Write("Ikä: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Oletko opiskelija? Y/N: ");
            Student = Console.ReadLine();
            Console.Write("Oletko varusmies? Y/N: ");
            Army = Console.ReadLine();
            Console.Write("Oletko mtk:n jäsen? Y/N: ");
            Mtk = Console.ReadLine();
        }
        public void PrintUserInfo()
        {
            Console.WriteLine($"Nimi: {User}\nIkä: {Age}\nOpiskelija: {Student}\nVarusmies: {Army}\nMtk:n jäsen: {Mtk}\n");
        }
        public void CountDiscount()
        {
            Price = 16;
            if (Age < 7)
                Discount = 100;
            else if (Age >= 7 && Age <= 15)
                Discount = 50;
            else if (Age >= 65)
                Discount = 50;
            else if (Student == "Y" || Student == "y")
                if (Student == "Y" && Mtk == "Y" || Student == "Y" && Mtk == "Y")
                {
                    Discount = 45 + 15;
                }
                else
                {
                    Discount = 45;
                }
            else if (Army == "Y" || Army == "y")
                Discount = 50;
            else if (Mtk == "Y" || Mtk == "y")
                Discount = 15;
            else
                Discount = 0;
            EndPrice=(Price - (Price * Convert.ToDecimal(Discount / 100m)));
            Console.WriteLine($"Lippusi hinta on: {EndPrice}\n");


        }
    }
}
