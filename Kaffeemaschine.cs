using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeemaschine
{
    internal class Kaffeemaschine
    {
        private int wasserstand;
        private int bohnenmenge;
        private static int maxWasserstand = 100;
        private static int maxBohnenmenge = 100;

        public Kaffeemaschine(int wasserstand, int bohnenmenge)
        {
            Wasserstand = wasserstand;
            Bohnenmenge = bohnenmenge;
        }

        public int Wasserstand { get => wasserstand; set => wasserstand = value; }
        public int Bohnenmenge { get => bohnenmenge; set => bohnenmenge = value; }
        public static int MaxWasserstand { get => maxWasserstand; set => maxWasserstand = value; }
        public static int MaxBohnenmenge { get => maxBohnenmenge; set => maxBohnenmenge = value; }

        public void KaffeZapfen()
        {
            if (Wasserstandspruefung() && Bohnenmengenpruefung())
            {
                Wasserstand = Wasserstand - 20;
                Bohnenmenge = Bohnenmenge - 8;
                Console.WriteLine("Hier bitte, dein Kaffee.");
                Thread.Sleep(3000);
            }
            else if (Wasserstandspruefung() == false && Bohnenmengenpruefung() == false)
            {
                Console.WriteLine("Bitte Wasser und Bohnen ausfüllen.");
                Thread.Sleep(3000);
            }
            else if (Wasserstandspruefung() == false && Bohnenmengenpruefung())
            {
                Console.WriteLine("Bitte Wasser ausfüllen.");
                Thread.Sleep(3000);
            }
            else if (Wasserstandspruefung() && Bohnenmengenpruefung() == false)
            {
                Console.WriteLine("Bitte Bohnen ausfüllen.");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Schwerer Ausnahmefehler. Bitte Techniker rufen.");
                Thread.Sleep(3000);
            }
        }
        private bool Wasserstandspruefung()
        {
            if (Wasserstand < 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Bohnenmengenpruefung()
        {
            if (Bohnenmenge < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void WasserMaximalstand()
        {
            Wasserstand = 100;
            Console.WriteLine("Wasserstand wieder auf Maximal.");
            Thread.Sleep(3000);

        }
        public void BohnenMaximalstand()
        {
            Bohnenmenge = 100;
            Console.WriteLine("Bohnenmenge wieder auf Maximal.");
            Thread.Sleep(3000);
        }

        public void KaffeTrinken()
        {
            bool wiederKaffe = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Was möchten Sie tun? 1/2/3\n\n\t1. Eine Kaffe trinken.\n\t2. Das Wasser ausfüllen\n\t3. Die Bohnen ausfüllen.");
                string Antwort = Console.ReadLine();
                if (Antwort == "1")
                {
                    KaffeZapfen();
                }
                else if (Antwort == "2")
                {
                    WasserMaximalstand();
                }
                else if (Antwort == "3")
                {
                    BohnenMaximalstand();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Falshe Antwort, veruschen Sie es erneut mit:\n\t1 für eine Kaffee\n\t2 die Wasser auszufüllen\n\t3 die Bohnen auszufüllen.");
                    Thread.Sleep(3000);
                }
            } while (wiederKaffe == true);
        }
    }
}
