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
            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            int aantalSchoenen = Convert.ToInt32(Console.ReadLine());
            if (aantalSchoenen > 1)
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
    }
}