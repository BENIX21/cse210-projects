using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Samuel Bennett", "Multiplication", "5", "10");
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine(m1.GetSummary());

        WritingAssignment w1 = new WritingAssignment("Samuel Bennett", "English", "The Importance of Punctuality");
        Console.WriteLine(w1.GetWritingInformation());
        Console.WriteLine(w1.GetSummary());

    }
}