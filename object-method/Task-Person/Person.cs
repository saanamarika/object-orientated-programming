using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    class Person
    {
        //Fields (Muuttujat)
        public string name;
        private int age;

        //Constructor (Konstruktori)
        public Person()
        {
            name = "unknown";
            age = 0;
        }
        public Person(string Name, int age)
        {
            name = Name;
            this.age = age;
        }
        //Methods (Metodit)
        public void GrowOld()
        {
            this.age++;
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nimi: {name}\nIkä: {this.age}\nAikuinen: {IsAdult()} ");
        }
        public bool IsAdult()
        {
            return this.age >= 18;

            //Voit tehdä sen myös näin:

            /*if (this.age >= 18)
                return true;
            else
                return false;*/
        }
        public int GetAge()
        {
            return this.age;
        }
    }
}
