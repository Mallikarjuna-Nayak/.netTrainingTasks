using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Format("{0} x {1} = {2}", x, y, MultiplyNumbers(x, y)));            
        }
        static double MultiplyNumbers(double x, double y)
        {
            return x / (1 / y);
        }
    }
}
