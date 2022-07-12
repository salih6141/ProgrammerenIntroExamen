using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class VariabelenEnDatatypes
    {
        public static void Optellen()
        {
            Console.WriteLine("Wat is het eerste getal?");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De som is " + (getal1 + getal2) + ".");
        }

        public static void VerbruikWagen()
        {
            int aantalLiterVoor = 0;
            int aantalLiterNa = 0;
            int kmVoor = 0;
            int kmNa = 0;

            Console.Write("Geef het aantal liter in de tank voor de rit: ");
            aantalLiterVoor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef het aantal liter in de tank na de rit: ");
            aantalLiterNa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef de kilometerstand voor de rit: ");
            kmVoor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef de kilometerstand na de rit: ");
            kmNa = Convert.ToInt32(Console.ReadLine());

            double verbruik = (100*(aantalLiterVoor - aantalLiterNa)/ (kmNa - kmVoor));
            Console.WriteLine("Het verbruik van de auto is: " + Math.Round(verbruik,2));
        }

        public static void Gemiddelde()
        {
            int getal1 = 18;
            int getal2 = 11;
            int getal3 = 8;
            int gemiddelde = (getal1 + getal2 + getal3)/3;
            Console.WriteLine(gemiddelde);
        }
    }
}