using System;

namespace ConstructorAndDestructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int total = 3;
            Person[] persons = new Person[total];
            for(int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }
            for(int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(String name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "My Name is " + Name;//base.ToString();
        }
        ~Person()
        {
            Name = string.Empty;
        }
    }
}
