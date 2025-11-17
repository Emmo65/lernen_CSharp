# 📚 Programmieren mit C# – Projektübersicht

Dieses Repository enthält alle Projekte aus dem Modul **„Programmieren mit C#“**.  
Jedes Projekt befindet sich in einem eigenen Unterordner und kann separat ausgeführt werden.

Die Projekte sind chronologisch geordnet:  
`000` → erste Übungen | `030` → letzter veröffentlichter Stand | `031` → neues Projekt (eigener Branch)

---

# 🗂 Projektliste

| Nr. | Projektname | Beschreibung |
|-----|-------------|--------------|
| 000–030 | Diverse Grundlagenprojekte | Konsolenprogramme, OOP-Übungen, Arrays, Methoden, kleinere Tools |
| **031** | **BlazorZahlraten** | WebAssembly-Zahlratenspiel mit futuristischer Dark-UI (eigener Branch) |

---

# 🧩 Projekt 031 – BlazorZahlraten  
**Branch:** `feature/031-blazor-zahlraten`

Ein modernes Zahlenratespiel umgesetzt mit **Blazor WebAssembly**.  
Der Spieler muss eine geheime Zufallszahl erraten und kann dabei abhängig vom Schwierigkeitsgrad verschiedene Hilfen nutzen.

Das Projekt demonstriert:

- Razor-Komponenten  
- State-Management in Blazor  
- UI-Design ohne Bootstrap  
- Arbeiten mit Branches (Feature Branch Flow)

---

## 🎨 Features

### 🔥 Benutzeroberfläche
- Futuristisches Dark Theme  
- Glas-/Blur-Navigationsleiste  
- Neon-Glowing Hover-Effekte  
- Hero-Startseite mit Intro & CTA  
- Mobile-optimiert

### 🕹 Spiel-Features
- Drei Schwierigkeitsgrade:
  - **Leicht** – 1–50  
  - **Mittel** – 1–100  
  - **Schwer** – 1–200  
- Zufallszahl-Generierung bei jedem Spielstart  
- Hinweise:
  - „zu hoch“
  - „zu niedrig“
  - „richtig“  
- Versuchszähler & Fortschrittsanzeige  
- Liste aller abgegebenen Tipps  
- Optionaler **Cheat-Modus** zum Anzeigen der Zahl

---

## 🚀 Projekt starten

```bash
cd 031_BlazorZahlraten
dotnet run
Danach im Browser öffnen:

https://localhost:5115


Seitenstruktur:

/ – Startseite (Hero, Start-Button)

/game – Zahlraten-Spiel
