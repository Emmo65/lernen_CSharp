using System;

class Controller
{
    public static void Start()
    {
        View.ZeigeText("Willkommen im Fahrzeugprogramm!");
        View.ZeigeLeerzeile();

        var f = new Fahrzeug("Mercedes", 2010);
        f.Vorstellen();

        View.ZeigeLeerzeile();

        var a = new Auto("VW", 2020, 4);
        a.Vorstellen();

        View.ZeigeLeerzeile();

        var e = new Elektroauto("Tesla", 2024, 4, 100);
        e.Vorstellen();

        View.ZeigeLeerzeile();
        View.ZeigeText("Polymorphismus-Demo:");
        Fahrzeug poly = new Elektroauto("BMW", 2025, 4, 85);
        poly.Vorstellen();

        // Alles Gesammelte in neuem Terminalfenster anzeigen
        View.RenderInNeuemFenster();
    }
}
