using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int random_number = random.Next(101);
        Console.WriteLine("Random number = " + random_number);
    }
}