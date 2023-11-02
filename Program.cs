using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter 'k' to generate a random number between 0-100 or 'q', 'quit', or 'exit' to exit");
            string input = Console.ReadLine().ToLower();

            if (input == "q" || input == "quit" || input == "exit")
            {
                break;
            }

            if (input == "k")
            {
                Random random = new Random();
                int random_number = random.Next(101);
                Console.WriteLine("Random number = " + random_number);
            }
            else
            {
                Console.WriteLine("Invalid input. Enter 'k' or 'q', 'quit', or 'exit'.");
            }
        }
    }
}
