using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr = new int[10]; // declare array of integers
            Console.WriteLine("Enter array elements up to 10:");
            for(i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());  // Reading elements
            }
            // checking and printing list of EVEN Integers
            Console.WriteLine("List of EVEN numbers:");
            for(i = 0; i < arr.Length; i++)
            {
                // Condition for EVEN number
                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i] + " is divisible by 2. So it's a EVEN number");
                }
            }
            Console.WriteLine();
        }
    }
}
