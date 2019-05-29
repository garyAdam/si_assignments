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

            Employee Kovacs = new Employee("Géza", 1988, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
        }
    }

    class Person
    {
        protected string name;
        protected int birthDate;

        public Person()
        {

        }
        public Person(string name, int birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

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
    class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;
        private Room room;

        public Employee(){
    
        }

        public Employee(string name, int birthDate, int salary, string profession) : base(name,birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            
        }

        public int Salary { get => salary; set => salary = value; }
        public string Profession { get => profession; set => profession = value; }

        public override string ToString()
        {
            return "Name: " + name + ", BirthDate: " + birthDate + ", Salary: " + salary + ", Profession: " + profession + ", Room Number: "+Room.RoomNumber;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }

        public Room Room { get => room; set => room = value; }
    }

    class Room
    {
        int roomNumber;
        public Room()
        {

        }

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
    }

    enum Genders
    {
        Male, Female
    }
}
