using System.Collections;

namespace Kaffeemaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1:
            //Erstelle die Klasse Kaffeemaschine.
            //Diese soll über die Felder "wasserstand" und bohnenmenge" verfügen.
            //Es soll auch zwei static Felder geben namens "maxWasserstand" und "maxBohnenmenge".
            //Die Klasse soll im Sinne der Datensicherheit gekapselt sein.

            //Aufgabe2:
            //Erstelle eine Methode um einen Kaffee zu machen. Dafür soll eine eine bestimmte Menge Wasser und eine bestimmte Menge Bohnen verbraucht werden.
            //Gib den Kaffee stellvertrenden über einen Console.WriteLine() aus.
            //Hinweis: Du musst selbt ein Objekt der Klasse Kaffeemaschine erstellen und beliebige entsprechende Werte zuweisen, um dann die Methode ausführen zu können. 

            //Aufgabe3: Erstelle Methoden um zu prüfen, ob noch ausreichend Wasser und Bohnen für einen Kaffe vorhanden sind. 
            //Diese beiden Methoden sollen dann in der für Aufgabe 2 erstellten Methode sinnvoll aufgerufen werden. 

            //Aufgabe4: Erstelle Methoden um die Wassermenge, als auch die Bohnenmenge wieder auf Maximalstand zu bringen.

            //Aufgabe5a: Schreibe Code der es uns ermöglicht wieder und wieder einen Kaffee aus der Maschine zu bekommen.
            //Aufgabe5b: Mache diesen Code zu einer Methode der Klasse.
            //Aufgabe5c: Verlagere alle bisherigen Methodenaufrufe aus der Programm.cs in die Methode aus 5b.
            //Diese Methode soll es dann ermöglichen, nach Nutzereingabe entweder einen Kaffee zu bekommen oder eine der Auffüllmethoden auszuführen.

            Kaffeemaschine kaffemaschine1 = new Kaffeemaschine(60, 10);

                kaffemaschine1.KaffeTrinken();
        }
    }
}