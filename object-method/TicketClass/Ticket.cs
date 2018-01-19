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
        public string Member;
        public string Member2;
        public string Member3;
        public int Price;
        public int Discount;
        public decimal EndPrice;

        public Ticket()
        {
            User = "";
            Age = 0;
            Member = "";
            Member2 = "";
            Member3 = "";
            Price = 20;
            Discount = 0;
            EndPrice = 0;
        }
        public Ticket(string user, int age, string member,string member2,string member3)
        {
            User = user;
            Age = age;
            Member = member;
            Member2 = member3;
            Member3 = member3;
            //Price = price;
        }
        public void AskData()
        {
            Console.Write("Nimi: ");
            User = Console.ReadLine();
            Console.Write("Ikä: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Oletko opiskelija? Y/N: ");
            Member = Console.ReadLine();
            Console.Write("Oletko varusmies? Y/N: ");
            Member2 = Console.ReadLine();
            Console.Write("Oletko mtk:n jäsen? Y/N: ");
            Member3 = Console.ReadLine();
        }
        public void PrintUserInfo()
        {
            Console.WriteLine($"Nimi: {User}\nIkä: {Age}\nOpiskelija: {Member}\nVarusmies: {Member2}\nMtk:n jäsen: {Member3}\n");
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
            else if (Member == "Y" || Member == "y")
                if (Member == "Y" && Member3 == "Y" || Member == "Y" && Member3 == "Y")
                {
                    Discount = 45 + 15;
                }
                else
                {
                    Discount = 45;
                }
            else if (Member2 == "Y" || Member2 == "y")
                Discount = 50;
            else if (Member3 == "Y" || Member3 == "y")
                Discount = 15;
            else
                Discount = 0;
            EndPrice=(Price - (Price * Convert.ToDecimal(Discount / 100m)));
            Console.WriteLine($"Lippusi hinta on: {EndPrice}\n");


        }
    }
}
