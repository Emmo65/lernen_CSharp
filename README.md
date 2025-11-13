# Programmieren mit C#

Sammlung meiner C#-Übungsaufgaben (Konsolenprojekte).
Alle Aufgaben liegen in `src/` in eigenen Projektordnern.

---

## Struktur

- `src/` – enthält alle Projekte (001_..., 002_..., …, 030_ConstructorVererbung)
- `README.md` – diese Datei
- `.gitignore` – ignoriert binäre Dateien wie `bin/`, `obj/`, `.exe`, `.dll`

---

## Ausführen eines Projekts

Beispiel:

1. In den Projektordner wechseln, z.B.:
   cd .\src\021_NameEingeben

2. Dann das Projekt starten:
   dotnet run

---

## Themenübersicht

- Grundlagen: Ausgabe, Variablen, Datentypen, Kommentare
- Rechnen, Bedingungen, Benutzereingabe
- Methoden und Funktionen
- OOP: Klassen, Konstruktoren, Vererbung, Polymorphismus

---

## OOP-Beispiel (030_ConstructorVererbung)

Dieses Projekt enthält:

- Fahrzeug.cs – Basisklasse
- Auto.cs – erbt von Fahrzeug
- Elektroauto.cs – erbt von Auto
- Controller.cs – steuert den Programmablauf
- View.cs – kümmert sich um Ausgaben (z.B. Konsole, neues Fenster)

---

## Technologien

- C# / .NET
- Visual Studio Code
- Windows PowerShell
- Git für Versionsverwaltung

---

## Hinweise

- Jedes Projekt ist ein eigenes Konsolenprogramm.
- Durch `.gitignore` werden Build-Ordner wie `bin/` und `obj/` nicht mit in Git übernommen.
- Die Aufgaben sind nummeriert, um den Lernfortschritt nachvollziehen zu können.

© 2025 Emrah – Lernprojekt C#
