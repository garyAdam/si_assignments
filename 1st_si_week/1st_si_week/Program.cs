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

            Employee employee = new Employee();
            employee.Name = "jozsi";
            employee.BirthDate = 1989;
            employee.Profession = "vizes";
            employee.Salary = 100000;
            Room room1 = new Room();
            room1.RoomNumber = 1;
            employee.Room = room1;
            Console.WriteLine( employee.ToString());
        }
    }

    class Person
    {
        protected string name;
        protected int birthDate;

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
    class Employee : Person
    {
        private int salary;
        private string profession;
        private Room room;


        public int Salary { get => salary; set => salary = value; }
        public string Profession { get => profession; set => profession = value; }

        public override string ToString()
        {
            return "Name: " + name + ", BirthDate: " + birthDate + ", Salary: " + salary + ", Profession: " + profession + ", Room Number: "+Room.RoomNumber;
        }
        public Room Room { get => room; set => room = value; }
    }

    class Room
    {
        int roomNumber;

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
    }

    enum Genders
    {
        Male, Female
    }
}
