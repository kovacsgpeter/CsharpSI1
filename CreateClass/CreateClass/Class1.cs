using System;
using System.Diagnostics;

namespace CreateClass
{
    public class Room
    {
        public int RoomNumber { get; }

        public Room(int rn) { this.RoomNumber = rn; }
    }
    public class Employee : Person, ICloneable
    {

        public Employee(string name, DateTime birthDate, Gender gender, decimal salary, string profession, Room room) : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.Room = room;
        }

        public Employee() : base()
        {
        }

        public decimal Salary { get; set; }
        public string Profession { get; set; }

        public Room Room { get; set; }

        public override string ToString()
        {
            return base.ToString() +" salary: "+ this.Salary + " profession: " + this.Profession +" roomnumber: "+this.Room.RoomNumber;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

       
    }
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return this.Name +" "+ this.Gender + " " + this.BirthDate;
        }

        public Person()
        {
        }

        public Person(string name, DateTime birthDate, Gender gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
        }
    }

    public enum Gender
    {
        MALE, FEMALE
    }

    public class TestClass
    {
        static void Main(string[] args)
        {
            
            var Peti = new Employee();
            Peti.Name = "Peter";
            Peti.Gender = Gender.MALE;
            Peti.BirthDate = new DateTime(1989, 7, 7);
            Peti.Profession = "Geologist";
            Peti.Salary = 1250;
            Peti.Room = new Room(34);
            var Miklos = new Employee("Miklos", new DateTime(1988, 4, 5), Gender.MALE, 1550, "Coder", new Room(45));
            Employee Miklos2 = (Employee)Miklos.Clone();
            Miklos2.Room = new Room(75);
            Console.WriteLine(Peti.ToString());
            Console.WriteLine(Miklos.ToString());
            Console.WriteLine(Miklos2.ToString());
            Console.ReadLine();
        }
    }
}

