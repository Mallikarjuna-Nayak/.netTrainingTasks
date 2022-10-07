using System;
using System.Text.RegularExpressions;

namespace IsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIsNumeric(Console.ReadLine());
            
        }
        public static void CheckIsNumeric(string input)
        {
            var op = Regex.IsMatch(input, @"^\d+$");
            if(op == true)
            {
                Console.WriteLine("Given input: " + input + " is a Number");
            }
            else
            {
                Console.WriteLine("Given input: " + input + " is not a Number");
            }
        }
    }
}
