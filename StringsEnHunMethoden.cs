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

        public static void LeetSpeak()
        {
            Console.WriteLine("Geef je tekst in");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput.Replace("a","@"));
        }

        public static void Instructies()
        {
            Console.WriteLine("Wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Wat is de naam van de cursus?");
            string cursus = Console.ReadLine();
            Console.WriteLine($"Maak een map als volgt: /home/{naam.Substring(0,3).ToUpper()}/{cursus}");
        }

        public static void Lotto()
        {
            Console.WriteLine("Wat zijn je cijfers (tussen 01 en 45)?");
            string cijfers = Console.ReadLine();
            Console.WriteLine("Je cijfers zijn:");
            Console.WriteLine($"{cijfers.Substring(0,8).Replace(",", "|")}");
            Console.WriteLine($"{cijfers.Substring(9,8).Replace(",","|")}");
        }
    }
}