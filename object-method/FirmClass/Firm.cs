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
        public int Phone;
        public int Outcome;
        public int Expense;

        public Firm()
        {
            Title = "";
            Address = "";
            Phone = 0;
            Outcome = 0;
            Expense = 0;
        }
        public Firm(string title, string address, int phone, int outcome, int expense)
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
    }
}
