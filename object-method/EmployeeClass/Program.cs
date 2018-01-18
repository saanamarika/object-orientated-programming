using System;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Employee employee1 = new Employee("Pahvi Pahvinen", 1234, "The Bossman", 10000);
            employee1.PrintEmployeeInfo();

            Employee employee2 = new Employee("Karto Kartonki", 1234, "Luuseri", 1500);
            employee2.PrintEmployeeInfo();

            Console.WriteLine(employee1.CompareSalary(employee2));


            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Kalle Lipponen",1234,"Välimalli",2500);
            employees[1] = new Employee("Risto Rasti",1234,"Pomon pomo",15000);
            employees[2] = new Employee("Teppo Testaaja",1234,"Johtaja",20000);

            Console.WriteLine(employees[0].CompareSalary(employees[1]));

            Console.ReadKey();
        }
    }
}
