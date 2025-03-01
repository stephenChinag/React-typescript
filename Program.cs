using System;

namespace ConsoleApp1
{
    internal class Program
    {
        // Method to calculate factorial
        public static double Factorial(int number)
        {
            if (number == 0)
            {
                return 1; // Base case: 0! = 1
            }
            else
            {
                return number * Factorial(number - 1); // Recursive case
            }
        }

        static void Main(string[]  args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
 
            // Input validation
            if (int.TryParse(input, out int n) && n >= 0)
            {
                Console.WriteLine("Factorial of " + n + " is " + Factorial(n));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }

            Console.ReadKey();
        }
    }
}