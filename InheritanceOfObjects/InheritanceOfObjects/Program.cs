using System;

namespace InheritanceOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter 3 Persons name:");
            int totalStudent = 3;
            Person[] persons = new Person[totalStudent];
            for(int i = 0; i < totalStudent; i++)
            {
                if( i == 0 )
                {
                    persons[i] = new Teacher(
                    Console.ReadLine()
                    );
                }
                else
                {
                    persons[i] = new Student(
                        Console.ReadLine()
                        );
                }
            }
            for(int i = 0; i < totalStudent; i++)
            {
                if ( i == 0 )
                {
                    ((Teacher)persons[i]).Explain();
                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "My name is: " + Name;//base.ToString();
        }
        ~Person()
        {
            Name = string.Empty;
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("My name is " + Name + ". I'm a teacher and I will explain");
        }
    }
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("My name is " + Name + ". I'm a Student and I'll study");
        }
    }
}
