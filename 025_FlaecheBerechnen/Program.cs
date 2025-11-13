using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gib die Länge der ersten Seite ein: ");
        string eingabe1 = Console.ReadLine();
        double seite1 = double.Parse(eingabe1);
        Console.WriteLine("Gib die Länge der zweiten Seite ein: ");
        string eingabe2 = Console.ReadLine();
        double seite2 = double.Parse(eingabe2);
        double flaeche = seite2 * seite1;
        Console.WriteLine($"Die Fläche beträgt {flaeche}.");
        
    }
}