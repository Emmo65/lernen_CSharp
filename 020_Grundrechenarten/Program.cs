using System;

class Program
{
    static void Main()
    {
        int a = 20;
        int b = 5;
        int summe = a + b;
        int differenz = a - b;
        int produkt = a * b;
        int quotient = a / b;

        Console.WriteLine("Addition" + a + "+" + b + "=" + summe);
        Console.WriteLine("Subtraktion" + a + "-" + b + "=" + differenz);
        Console.WriteLine("Multiplikation" + a + "*" + b + "=" + produkt);
        Console.WriteLine("Division" + a + "/" + b + "=" + quotient);
    }
}