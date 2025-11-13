using System;

class Eingabe
{
    public static void FragePersonAb()
    {
        Console.WriteLine("Wie heißt du?");
        string name = Console.ReadLine();

        Console.WriteLine("Wie alt bist du?");
        int alter = int.Parse(Console.ReadLine());

        Console.WriteLine("Was arbeitest du?");
        string arbeit = Console.ReadLine();

        Console.WriteLine("Wo wohnst du?");
        string ort = Console.ReadLine();

        Person p = new Person(name, alter, arbeit, ort);
        p.Vorstellen();
    }
}
