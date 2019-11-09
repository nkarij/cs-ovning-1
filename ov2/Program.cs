using System;

namespace ov2
{
    class Program
    {
        static void Main(string[] args)
        {
            // console ask for name
            // console read line, save to string var.
            // console ask for surname
            // console read line, save to string var.
            // console write full name in template string.

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            string surName = Console.ReadLine();
            System.Console.WriteLine($"Your full name is {name} {surName}");
        }
    }
}
