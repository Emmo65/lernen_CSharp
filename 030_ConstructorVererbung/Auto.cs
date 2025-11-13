using System;

class Auto : Fahrzeug
{
    public int Tueren;

    public Auto(string marke, int baujahr, int tueren)
        : base(marke, baujahr)
    {
        Tueren = tueren;
    }

    public override void Vorstellen()
    {
        View.ZeigeText($"Ich bin ein Auto der Marke {Marke}, Baujahr {Baujahr}, mit {Tueren} Türen.");
    }
}
    