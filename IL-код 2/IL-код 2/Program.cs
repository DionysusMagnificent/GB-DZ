using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "5555";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();
            if (input == secret)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}