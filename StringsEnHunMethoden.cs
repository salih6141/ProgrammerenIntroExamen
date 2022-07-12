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
    }
}