using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class Methoden
    {
        public static void BerkenStraal(double diameter){
            double straal = diameter/2;
            Console.WriteLine($"De straal van de cirkel is: {Math.Round(straal,2)}");
        }
        public static void BerkeneOmtrek(double diameter){
            double omtrek = (Math.PI * diameter);
            Console.WriteLine($"De omtrek van de cirkel is: {Math.Round(omtrek,2)}");
        }
        public static void Maximum(double getal1, double getal2){
            if (getal1 > getal2){
                Console.WriteLine($"Het grootste getal tussen {getal1} en {getal2} is {getal1}.");
            }
            else if (getal2 > getal1)
            {
                Console.WriteLine($"Het grootste getal tussen {getal1} en {getal2} is {getal2}.");
            }
        }
    }
}