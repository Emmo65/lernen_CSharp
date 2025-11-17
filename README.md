# 📚 Programmieren mit C# – Projektübersicht

Dieses Repository enthält alle Projekte aus dem Modul **„Programmieren mit C#“**.  
Jedes Projekt befindet sich in einem eigenen Unterordner und kann separat ausgeführt werden.

Die Projekte sind chronologisch geordnet:  
`000` → erste Übungen  
`030` → letzter veröffentlichter Stand  
`031` → neues Projekt (eigener Branch)

---

# 🗂 Projektliste

| Nr.   | Projektname            | Beschreibung                                              |
|-------|-------------------------|-----------------------------------------------------------|
| 000–030 | Verschiedene Übungen | Konsolenprogramme, OOP, Arrays, Methoden, Tools          |
| **031** | **BlazorZahlraten**  | WebAssembly-Zahlratenspiel mit futuristischer Dark-UI    |

---

# 🧩 Projekt 031 – BlazorZahlraten  
**Branch:** `feature/031-blazor-zahlraten`

Ein modernes Zahlenratespiel umgesetzt mit **Blazor WebAssembly**.  
Der Spieler muss eine geheime Zufallszahl erraten und kann abhängig vom Schwierigkeitsgrad verschiedene Hilfen nutzen.

Dieses Projekt demonstriert:

- Razor-Komponenten  
- State-Management in Blazor  
- UI-Design komplett ohne Bootstrap  
- Arbeiten im Feature-Branch-Workflow  
- Modernes Dark-/Neon-Design

---

## 🎨 Features

### 🔥 Benutzeroberfläche
- Futuristisches Dark Theme  
- Glas-/Blur-Navigationsleiste  
- Neon-Hover-Effekte  
- Hero-Startseite mit Intro und CTA  
- Mobile-responsive

### 🕹 Spiel-Features
- Drei Schwierigkeitsgrade:
  - **Leicht**: Bereich 1–50  
  - **Mittel**: Bereich 1–100  
  - **Schwer**: Bereich 1–200  
- Zufallszahl wird bei jedem Spiel neu generiert  
- Hinweise („zu hoch“, „zu niedrig“, „richtig“)  
- Fortschrittsanzeige  
- Versuchszähler  
- Liste aller abgegebenen Tipps  
- Optionaler **Cheat-Modus** zum Anzeigen der Zahl

---

## 🚀 Projekt starten

Im Ordner **031_BlazorZahlraten**:

```bash
dotnet run
Danach im Browser öffnen:

arduino
Code kopieren
https://localhost:5115
Seiten:

/ – Startseite (Hero)

/game – Hauptspiel

📁 Projektstruktur
text
Code kopieren
031_BlazorZahlraten/
├─ Layout/
│  ├─ MainLayout.razor
│  └─ NavMenu.razor
├─ Pages/
│  ├─ Home.razor
│  └─ Game.razor
├─ wwwroot/
│  ├─ css/app.css          # globales Dark Theme + Navbar Styles
│  └─ index.html           # Bootstrap entfernt
├─ Program.cs
└─ 031_BlazorZahlraten.csproj
🧪 Entwicklungs-Workflow (für den Dozenten)
Dieses Projekt wurde über einen professionellen Feature-Branch entwickelt:

bash
Code kopieren
git checkout -b feature/031-blazor-zahlraten
git add .
git commit -m "feat(031): add Blazor Zahlenraten"
git push -u origin feature/031-blazor-zahlraten
Vorteile:

sauber getrennte Entwicklung

keine Änderungen am main-Branch

Präsentation über Pull Request möglich

📝 Hinweise
Bootstrap wurde bewusst entfernt, um volle Kontrolle über das UI zu haben.

Das Projekt läuft vollständig clientseitig in WebAssembly.

Code ist modular, klar kommentiert und leicht vorführbar.

✔ Lizenz
Nur zur Ausbildung – keine Lizenzbeschränkungen.

yaml
Code kopieren

---

# Fertig.  
