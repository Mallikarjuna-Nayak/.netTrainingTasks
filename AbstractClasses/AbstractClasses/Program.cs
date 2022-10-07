using System;
using System.Linq;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dog name: ");
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            dog.Eat();
        }
    }
    public abstract class Animal
    {
        private string Name;
        public void SetName(string name)
        {
            Name = name;            
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            bool isAlpha = GetName().All(Char.IsLetter);
            if (isAlpha == true)
            {
                Console.WriteLine(GetName() + " is eating");
            }
            else
            {
                Console.WriteLine("Enter Characters Only");
            }
        }
    }
}
