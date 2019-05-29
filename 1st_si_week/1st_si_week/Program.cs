using System;

namespace _1st_si_week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person();
            person.BirthDate = 1998;
            person.Name = "Johnnyy";
            Console.WriteLine(person.ToString());
        }
    }

    class Person
    {
        string name;
        int birthDate;

        public int BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public override string ToString()
        {
            return "Name: " + name + ", BirthDate: " + birthDate;
            
        }



    }
    enum Genders
    {
        Male, Female
    }
}
