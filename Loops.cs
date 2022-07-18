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
                Console.Clear();
            }
        }
    }

}