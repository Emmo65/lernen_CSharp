using System;

class Fahrzeug
{
    public string Marke;
    public int Baujahr;

    public Fahrzeug(string marke, int baujahr)
    {
        Marke = marke;
        Baujahr = baujahr;
    }

    public virtual void Vorstellen()
    {
        View.ZeigeText($"Ich bin ein Fahrzeug der Marke {Marke}, Baujahr {Baujahr}.");
    }
}
