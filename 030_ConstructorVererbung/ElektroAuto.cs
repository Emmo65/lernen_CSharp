using System;

class Elektroauto : Auto
{
    public int BatterieKapazitaet; // kWh

    public Elektroauto(string marke, int baujahr, int tueren, int batterie)
        : base(marke, baujahr, tueren)
    {
        BatterieKapazitaet = batterie;
    }

    public override void Vorstellen()
    {
        View.ZeigeText(
            $"Ich bin ein Elektroauto der Marke {Marke}, Baujahr {Baujahr}, mit {Tueren} Türen und einer Batterie von {BatterieKapazitaet} kWh."
        );
    }
}
