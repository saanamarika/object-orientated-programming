using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClass
{
    class Employee
    {
        //fields
        public string Name;
        public int Id;
        public string Position;
        public int Salary;

        public Employee()
        {
            Name = "";
            Id = 0;
            Position = "";
            Salary = 0;
        }
        public Employee(string name,int id,string position,int salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }
        //methods
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työntekijä: {Name}\nId: {Id}\nTitteli: {Position}\nKuukausipalkka: {Salary}\n");
        }
        public string CompareSalary(Employee employee)
        {
            if (this.Salary < employee.Salary)
                return ($"Henkilön {this.Name} kuukausipalkka on pienempi, kuin henkilön {employee.Name} palkka\n");
            return ($"Henkilön {this.Name} kuukausipalkka on suurempi, kuin henkilön {employee.Name}\n");
        }
    }
}
