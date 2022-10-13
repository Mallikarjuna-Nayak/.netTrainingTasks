using System;
using System.Collections;

namespace ArrayListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Enter 3 persons and their age:");
            int total = 3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new Person()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} and Age: {Age}";
        }
    }
}
