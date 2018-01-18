using System;
using System.Collections.Generic;
using System.Text;

namespace FirmClass
{
    class Firm
    {
        //Fields
        public string Title;
        public string Address;
        public string Phone;
        public int Outcome;
        public int Expense;

        public Firm()
        {
            Title = "";
            Address = "";
            Phone = "";
            Outcome = 0;
            Expense = 0;
        }
        public Firm(string title, string address, string phone, int outcome, int expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
        }
        public Firm(Firm previousNumber)
        {
            Title = previousNumber.Title;
            Address = previousNumber.Address;
            Phone = previousNumber.Phone;
            Outcome = previousNumber.Outcome;
            Expense = previousNumber.Expense;
        }
        //methods
       public void printInfo()
        {
            Console.WriteLine($"Firma: {Title}\nOsoite: {Address}\nPuhelin: {Phone}\nTulot: {Outcome}\nMenot: {Expense}");
        }
        public void howIsGoing()
        {
            int win = (Outcome - Expense) / Expense * 100;
            Console.WriteLine($"Firman voitto%: {win}");
            if (win < 100&&win>0)
                Console.WriteLine("Firmalla menee helevetin huonosti.\n");
            else if (win >= 100 && win < 200&&win>0)
                Console.WriteLine("Firmalla menee kehnosti.\n");
            else if (win >= 200 && win < 300)
                Console.WriteLine("Firmalla menee tyydyttävästi.\n");
            else if (win >= 300)
                Console.WriteLine("Firmalla menee todella hyvin!\n");
            else
                Console.WriteLine("Firmalla menee niin huonosti, että koodikin sekoaa...");



        }
    }
}
