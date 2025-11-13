using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wie ist dein Vorname: ");
        string vorname = Console.ReadLine();
        Console.WriteLine("Wie ist dein Nachname: ");
        string nachname = Console.ReadLine();
        Console.WriteLine($"Hallo {vorname} {nachname}, herzlich willkommen. "); 
    }

}