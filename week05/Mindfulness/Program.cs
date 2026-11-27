using System;

// 1. Added a session activity counter that tracks and displays how many activities the user has completed during the current session.
// 2. Modified ReflectingActivity to ensure no reflection questions are repeated until all questions in the list have been used at least once.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int activitiesCompleted = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine($"Activities completed this session: {activitiesCompleted}\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activitiesCompleted++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                activitiesCompleted++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activitiesCompleted++;
            }
        }

        Console.WriteLine($"\nGreat job! You completed {activitiesCompleted} activities today. Goodbye!");
    }
}