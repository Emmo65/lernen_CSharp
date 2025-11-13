using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gib die Temperatur in Celsius ein: ");
        string eingabe = Console.ReadLine();
        double temp = double.Parse(eingabe);
        double fahrenheit = temp * 9 / 5 + 32;
        Console.WriteLine($"{temp} Grad Celsius sind {fahrenheit:F2} Fahrenheit.");
    }
}