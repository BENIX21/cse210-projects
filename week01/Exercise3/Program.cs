using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {

            Console.Write($"what is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

            else
            {
                Console.WriteLine("Higher");
            }

        }




    }
}