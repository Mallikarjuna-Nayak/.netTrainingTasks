using System;

namespace task1
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
                persons[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }

            for(int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return "My name is " + Name; //base.ToString();
        }
    }
}
