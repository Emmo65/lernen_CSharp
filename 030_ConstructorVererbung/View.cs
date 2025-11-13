using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

class View
{
    private static readonly List<string> _buffer = new List<string>();

    public static void ZeigeText(string text)
    {
        Console.WriteLine(text);   // Live in aktueller Konsole
        _buffer.Add(text);         // zusätzlich für Zweitfenster sammeln
    }

    public static void ZeigeLeerzeile()
    {
        Console.WriteLine();
        _buffer.Add("");
    }

    // Zeigt ALLE gesammelten Zeilen in einem neuen CMD-Fenster (UTF-8, ohne Befehls-Echos)
    public static void RenderInNeuemFenster()
    {
        var tempCmd = Path.Combine(Path.GetTempPath(), "ViewOutput.cmd");

        // WICHTIG: UTF8Encoding(false) -> KEIN BOM schreiben!
        using (var sw = new StreamWriter(tempCmd, false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)))
        {
            sw.WriteLine("@echo off");
            // UTF-8 Codepage aktivieren, sonst Umlaute kaputt
            sw.WriteLine("chcp 65001>nul");
            sw.WriteLine();

            foreach (var line in _buffer)
            {
                if (string.IsNullOrEmpty(line))
                    sw.WriteLine("echo.");
                else
                    sw.WriteLine("echo " + line);
            }

            sw.WriteLine();
            sw.WriteLine("echo.");
            sw.WriteLine("echo (Fenster schließt nach Tastendruck)");
            sw.WriteLine("pause");
        }

        // .cmd starten -> neues Terminalfenster
        Process.Start(new ProcessStartInfo
        {
            FileName = tempCmd,
            UseShellExecute = true
        });
    }

    // Optional: Alternative, zeigt den Text in Notepad an (immer korrekt, super simpel)
    public static void RenderInNotepad()
    {
        var tempTxt = Path.Combine(Path.GetTempPath(), "ViewOutput.txt");
        // Notepad versteht UTF-8 mit BOM zuverlässig
        File.WriteAllLines(tempTxt, _buffer, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));

        Process.Start(new ProcessStartInfo
        {
            FileName = "notepad.exe",
            Arguments = $"\"{tempTxt}\"",
            UseShellExecute = true
        });
    }
}
