using System;

class Person
{
    public string name;
    public int alter;
    public string arbeit;
    public string wohnt;

    public Person(string n, int a, string arb, string ort)
    {
        name = n;
        alter = a;
        arbeit = arb;
        wohnt = ort;
    }

    public void Vorstellen()
    {
        Console.WriteLine($"Hallo, ich heiße {name}, bin {alter} Jahre alt, arbeite als {arbeit} und wohne in {wohnt}.");
    }
}
