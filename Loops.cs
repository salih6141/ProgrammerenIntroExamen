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
    }
}