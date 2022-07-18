using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class Loops
    {      
        public static void CountDown()
        {
            Console.Write("Geef een getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            if (getal > 0)
            {
                do
                {
                    Console.WriteLine(getal);
                    getal--;
                }
                while (getal > 0);
            }
            else
            {
                Console.WriteLine("Getal mag niet onder de nul zijn! start de programma opnieuw.");
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
                Console.Clear();
            }
        }

        public static void Wachtwoord()
        {
            string wachtwoord = "";
            int aantal = 0;
            string psw = "AP";
            while (wachtwoord != psw)
            {
                Console.Write("Voer het wachtwoord in: ");
                wachtwoord = Console.ReadLine();
                aantal++;
            }
            Console.WriteLine("Wachtwoord is correct!");
            Console.WriteLine($"aantal pogingen: {aantal}");
        }

        public static void Gemiddelde()
        {
            int aantalGetallen = -1;
            double somGetallen = 0;
            double getal = 1;
            while (getal != 0)
            {
                Console.Write("Voer het volgende getal in: ");
                getal = Convert.ToDouble(Console.ReadLine());
                somGetallen += getal;
                aantalGetallen++;
            }
            Console.WriteLine($"Het gemiddelde: {Math.Round(somGetallen/aantalGetallen,2)}");
        }

        public static void Feestje()
        {
            bool volzet = false;
            string check = "";
            string aanwezigen = "";
            int aantal = 0;
            while (volzet == false)
            {
                Console.Write("Wil je een volgende persoon inschrijven? (ja of nee)");
                check = Console.ReadLine();
                if (check == "ja")
                {
                    aantal++;
                    Console.Write("Geef de naam: ");
                    aanwezigen += " " + Console.ReadLine();
                }
                else if (check == "nee")
                {
                    volzet = true;
                    Console.WriteLine($"Lijst van aanwezigen: {aanwezigen}");
                    Console.WriteLine($"Er zijn {aantal} personen aanwezig.");
                }
            }
        }

        public static void RNATranscriptie()
        {
            string invoer = "";
            string DNA = "";
            string RNA = "";
            Console.WriteLine("Voer de letters 'G' 'T' 'C' of 'A' in.");
            do
            {
                Console.WriteLine("Voer de letter in (stoppen met 'stop'");
                invoer = Console.ReadLine();
                switch(invoer)
                {
                    case "G":
                        DNA += "G";
                        RNA += "C";
                        break;
                    case "C": 
                        DNA += "C";
                        RNA += "G";
                        break;
                    case "T":
                        DNA += "T";
                        RNA += "A";
                        break;
                    case "A":
                        DNA += "A";
                        RNA += "U";
                    break;
                }
            } while (invoer != "stop");
            Console.WriteLine($"De RNA string is : {RNA}");
        }

        public static void VanMin100Tot100()
        {
            for (int i = -100; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void EenTafel()
        {
            Console.WriteLine("Van welk getal wil je de tafel van vermenigvuldiging zien?");
            int getal = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {getal} is {i*getal}");
            }
        }
    }
}