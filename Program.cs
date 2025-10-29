using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Loading the ultimate program...");
            Console.WriteLine("Complete!");
            Console.WriteLine("Hello, World!" + "\n");

            //Console.Read(), Console.ReadKey(), or Console.ReadLine().
            Console.Write("Enter in a single character value for Console.Read():");
            int readValue = Console.Read();
            Console.WriteLine($"You entered:" + (char)readValue + "\n");// Casting int to char to display the character entered
            Console.ReadLine(); // Consumes the remaining newline character from the input buffer

            Console.Write("Enter a key to continue using Console.ReadKey():");
            //Assign a user entered value from Console.ReadKey() to a variable
            ConsoleKeyInfo readKey = Console.ReadKey(); // ReadKey() returns a ConsoleKeyInfo object
            Console.WriteLine($"\nYou entered:" + readKey.KeyChar + "\n");

            Console.Write("Running Console.ReadLine(). Enter your name:");
            string readName = Console.ReadLine();
            Console.WriteLine($"Hello, {readName}!\n");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}