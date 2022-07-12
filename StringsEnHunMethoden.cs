using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class StringsEnHunMethoden
    {
        public static void StringsEnHunHoofdletters()
        {
            Console.WriteLine("Welke tekst moet ik omzetten?");
            string invoer = Console.ReadLine();
            Console.WriteLine(invoer.ToUpper());
        }

        public static void BerekenBtw()
        {
            Console.Write("Geef het bedrag in: ");
            int bedrag = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef BTW percentage in: ");
            int btwPercentage = Convert.ToInt32(Console.ReadLine());
            int bedragInclusiefBtw = bedrag + (bedrag/100*btwPercentage);
            Console.WriteLine($"Het bedrag {bedrag} met {btwPercentage}% btw bedraagt {bedragInclusiefBtw}");
        }


    }
}