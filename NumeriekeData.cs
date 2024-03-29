using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class NumeriekeData
    {
        public static void ToonLadder(){
            string[] noten = {"do", "re", "mi", "fa", "sol", "la", "si" };
            Random random = new Random();
            int nootIndex = random.Next(7);
            Console.WriteLine($"Je willekeurige noot is {noten[nootIndex]} Hoeveel trappen wil je stijgen?");
            int aantalTrappen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Je komt uit op {noten[(nootIndex + aantalTrappen)%noten.Length]}");
        }

        public static void Chronometer(){
            int aantalHondersteSeconden = 0;
            while (true)
            {
                Thread.Sleep(10);
                Console.Clear();
                aantalHondersteSeconden++;
                Console.WriteLine($":{(aantalHondersteSeconden / 100) % 60:d2}:{aantalHondersteSeconden%100:d2}");
            }
        }

        public static void Cirkels(){
            Console.WriteLine("Geef de straal: ");
            double straal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De omtrek van de cirkel met straal {straal:F2} is {(straal * 2.0 * Math.PI):F2}");
            Console.WriteLine($"De oppervlakte van de cirkel met straal {straal:F2} is {(Math.Pow(straal, 2.0) * Math.PI):F2}");
        }
         public static void RWaarde()
        {
            Console.WriteLine("Wat is de R-waarde?");
            double rWaarde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel generaties kijken we vooruit?");
            int aantalGeneraties = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ben je O ptimistisch, N eutraal of P essimistisch?");
            string OpNePe = Console.ReadLine();

            Console.WriteLine("Het aantal besmettingen per generatie is:");
            for (int i = 0; i < aantalGeneraties; i++)
            {
                if (OpNePe == "O")
                {
                    Console.WriteLine($"Generatie {i + 1}: {Math.Floor(Math.Pow(rWaarde, i)):F0}");
                }
                else if (OpNePe == "P")
                {
                    Console.WriteLine($"Generatie {i + 1}: {Math.Ceiling(Math.Pow(rWaarde, i)):F0}");
                }
                else
                {
                    Console.WriteLine($"Generatie {i + 1}: {Math.Round(Math.Pow(rWaarde, i)):F0}");
                }
            }
        }
    }
}