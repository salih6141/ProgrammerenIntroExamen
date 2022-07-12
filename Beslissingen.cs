using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class Beslissingen
    {
        public static void Schoenenverkoper()
        {
            double prijsSchoen = 50.00;
            double bedrag = 00.00;
            Console.WriteLine("Heb je een klantenkaart?(ja of nee)");
            string klantenkaart = Console.ReadLine();
            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            int aantalSchoenen = Convert.ToInt32(Console.ReadLine());
            if (aantalSchoenen > 1 && klantenkaart == "ja")
            {
                bedrag = Math.Round((aantalSchoenen * prijsSchoen) * 0.9 , 2);
                Console.WriteLine($"De prijs voor {aantalSchoenen} paar schoenen is {bedrag}");
            }
            else
            {
                bedrag = Math.Round(aantalSchoenen * prijsSchoen,2);
                Console.WriteLine($"De prijs voor {aantalSchoenen} paar schoenen is {bedrag}");
            }
        }

        public static void EvenOneven()
        {
            Console.WriteLine("Geef een getal:");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal%2 == 0)
            {
                Console.WriteLine($"Het getal {getal} is even");
            }
            else
            {
                Console.WriteLine($"Het getal {getal} is oneven");
            }
        }

        public static void PositiefNegatiefNul()
        {
            int getal = 0;
            Console.WriteLine("Geef een getal: ");
            getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 0)
            {
                Console.WriteLine($"Het getal {getal} is positief.");
            }
            else if (getal < 0)
            {
                Console.WriteLine($"Het getal {getal} is negatief.");
            }
            else if (getal == 0)
            {
                Console.WriteLine($"Het getal is nul.");
            }
        }
    }
}