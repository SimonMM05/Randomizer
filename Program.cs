using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! Welcome to my program. This program allows you to generate a random number between 0-100.");
        Console.WriteLine("________________________________________________________________________________________________");
        
        while (true)
        {
            Console.WriteLine("Enter 'g' or 'generate' to generate a random number between 0-100, or 'q', 'quit', or 'exit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "q" || input == "quit" || input == "exit")
            {
                break;
            }
            else if (input == "g" || input == "generate")
            {
                Random random = new Random();
                int random_number = random.Next(101);
                Console.WriteLine("Random number = " + random_number);
                Console.WriteLine("Press 'c' key to continue or any other key to exit.");
                string continueInput = Console.ReadLine().ToLower();

                if (continueInput != "c")
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter 'g' or 'generate' to generate a number, or 'q', 'quit', or 'exit' to exit.");
            }
        }
    }
}
