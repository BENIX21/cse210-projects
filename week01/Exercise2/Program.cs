using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string textVersion = "";
            if (number >= 90)
            {
            textVersion = "A";
            }
            else if (number >= 80)
            {
            textVersion = "B";
            }
            else if (number >= 70  )
            {
            textVersion = "C";
            }
            else if (number >= 60)
            {
            textVersion = "D";
            }
            else
            {
            textVersion = "F";
            }

            Console.Write($"Your grade is an \"{textVersion}\". ");
        
            if (number >= 70)
            {
                Console.WriteLine($"You passed congratulations!");
            }
            else
            {
                Console.WriteLine($"Not a pass. Keep trying.");
            }
        }
}






