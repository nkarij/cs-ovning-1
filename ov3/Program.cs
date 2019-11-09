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

            Console.WriteLine("Name of first characther?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Surname of first character?");
            string surName1 = Console.ReadLine();

            Console.WriteLine("Name of second characther?");
            string name2 = Console.ReadLine();

            Console.WriteLine("Surname of second character?");
            string surName2 = Console.ReadLine();

            string personOne = $"{name1} {surName1}";
            string personTwo = $"{name2} {surName2}";

            Console.WriteLine($"Its saturday and the weather is sunny outside. {personOne} wants to go to the beach and play volley. He/she calls {personTwo} and asks if he/she wants to join. Unfortunately {personTwo} is caught up on work, since he/she is a developer. But {personTwo} promises to join for a beach barbeque after hours. {personOne} and {personTwo} spends a jolly evening toghether with beach, beers and barbecue");
        }
    }
}
