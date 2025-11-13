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
        int ergebnis = zahl1 + zahl2;
        Console.WriteLine("Das Ergebnis lautet: " + ergebnis);

    }
}