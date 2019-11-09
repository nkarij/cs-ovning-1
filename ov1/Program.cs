using System;

namespace ov1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string var for reading input
            // string method for writing (reading input)
            Console.WriteLine("What is your name?");
            string nameInput = Console.ReadLine();
            Console.WriteLine($"Your name is: {nameInput}");
        }
    }
}
