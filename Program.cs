using System;

namespace EmployeeDatabase2
{
    class Program
    {
        // Display Greeting
        static void DisplayGreeting()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to our Employee Database");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        // Prompt for string
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        // Prompt for integer
        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            var userInput = int.Parse(Console.ReadLine());

            return userInput;
        }
        static void Main(string[] args)
        {
            DisplayGreeting();

            var name = PromptForString("What is your name? ");

            Console.Write("What is your department number? ");
            int department = PromptForInteger("What is your department number? ");

            Console.Write("What is your yearly salary (in dollars)");
            int salary = PromptForInteger("What is your yearly salary (in dollars)");

            Console.WriteLine($"Hello, {name} you make {salary / 12} dollars per month.");
        }
    }
}
