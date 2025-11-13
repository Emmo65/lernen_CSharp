using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gib die erste Zahl ein: ");
        string eingabe1 = Console.ReadLine();
        int zahl1 = int.Parse(eingabe1);
        Console.WriteLine("Gib die zweite Zahl ein: ");
        string eingabe2 = Console.ReadLine();
        int zahl2 = int.Parse(eingabe2);
        Console.WriteLine($"Addition: {zahl1 + zahl2}");
        Console.WriteLine($"Subtraktion: {zahl1 - zahl2}");
        Console.WriteLine($"Multiplizieren: {zahl1 * zahl2}");
        Console.WriteLine($"Division: {zahl1 / zahl2}");
    }
}