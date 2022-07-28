using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammerenIntroExamen
{
    public class Arrays
    {
        public static void Arrayoefening()
        {
            bool[] trueFalseArray = new bool[30];

            for (int i = 0; i < trueFalseArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    trueFalseArray[i] = true;
                }
                else
                {
                    trueFalseArray[i] = false;
                }
                Console.WriteLine(trueFalseArray[i] + " ");
            }
        }

        public static void ArrayOefener()
        {
            int[] getallen = new int[10];
            Console.WriteLine("Voer 10 getallen in.");
            int som = 0;
            int grootsteGetal = 0;
            
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = Convert.ToInt32(Console.ReadLine());
                som += getallen[i];
            }//invoer en som berekening

            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] > grootsteGetal)
                    grootsteGetal = getallen[i];
            }//we zetten grootsteGetal op nul en doorlopen de array als de index i groter is dan grootste getal dan neemt grootsteGetal de waarde over en test het opnieuw...
            Console.WriteLine("**********");
            Console.WriteLine($"Som is {som}, Gemiddelde is {(double)som / getallen.Length}, Grootste getal is {grootsteGetal}");
            Console.WriteLine("**********");

            Console.WriteLine("Geef minimum getal in?");
            int invoer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("..........");
            if (invoer > grootsteGetal){
                Console.WriteLine("dit getal is te groot voor deze array");
            }
            else
            {
                for (int i = 0; i < getallen.Length; i++)
                {
                    if (getallen[i] >= invoer)
                        Console.WriteLine($"{getallen[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}