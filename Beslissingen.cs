using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class Beslissingen
    {
        public static void KeuzeMenu()
        {
            Console.WriteLine("Kies een oefening.");
            Console.WriteLine("1 - Schoenenverkoper");
            Console.WriteLine("2 - EvenOneven");
            Console.WriteLine("3 - PositiefNegatiefNul");
            Console.WriteLine("4 - BMIBerekenaar");
            int keuze = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (keuze)
            {
                case 1:
                    Schoenenverkoper();
                    break;
                case 2:
                    EvenOneven();
                    break;
                case 3:
                    PositiefNegatiefNul();
                    break;
                case 4:
                    BMIBerekenaar();
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze!");
                    break;
            }
        }

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

        public static void BMIBerekenaar()
        {
            Console.WriteLine("Wat is je gewicht?");
            double gewicht = Convert.ToDouble(Console.ReadLine());
        
            Console.WriteLine("Wat is je lengte in meter?");
            double lengte = Convert.ToDouble(Console.ReadLine());
            double bmi = Math.Round(gewicht/Math.Pow(lengte,2),2);

            if (bmi < 18.5)
            {
                Console.WriteLine($"Je hebt een bmi van {bmi}. Je bent ondergewicht.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"Je hebt een bmi van {bmi}. Je hebt een normaal gewicht.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine($"Je hebt een bmi van {bmi}. Je bent overgewicht.");
            }
            else if (bmi >= 30 && bmi < 40)
            {
                Console.WriteLine($"Je hebt een bmi van {bmi}. Je bent zwaarlijvig.");
            }
            else if (bmi >= 40) 
            {
                Console.WriteLine($"Je hebt een bmi van {bmi}. Je hebt ernstige obesitas.");
            }
        }
    }
}