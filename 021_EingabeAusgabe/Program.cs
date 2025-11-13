using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wie ist dein Name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Herzlich Willkommen " + name + ".");
        Console.WriteLine("Wie alt bist du? ");
        string eingabe = Console.ReadLine();
        int alter = int.Parse(eingabe);
        Console.WriteLine(name+ " ist " + alter + " Jahre alt.");
    }
}
