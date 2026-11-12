using System;

class Program
{
    static void Main(string[] args)
    {
        // Probar los 3 constructores
        Fraction f1 = new Fraction();        
        Fraction f2 = new Fraction(5);       
        Fraction f3 = new Fraction(3, 4);     
        Fraction f4 = new Fraction(1, 3);     

        // Mostrar resultados usando los métodos
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Probar Setters y Getters
        Console.WriteLine("\nProbando setters:");
        f1.SetTop(6);
        f1.SetBottom(7);
        Console.WriteLine(f1.GetFractionString()); 
    }
}