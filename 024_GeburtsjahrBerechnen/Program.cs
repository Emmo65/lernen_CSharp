using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Wie alt bist du? ");
        string eingabe = Console.ReadLine();
        int alter = int.Parse(eingabe);
        int aktuellesJahr = DateTime.Now.Year;
        int deinJahr = aktuellesJahr - alter;
        Console.WriteLine($"Du bist ungefähr im Jahr {deinJahr} geboren.");

    }
}