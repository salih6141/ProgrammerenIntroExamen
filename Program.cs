﻿using System;

namespace ProgrammerenIntroExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            // VariabelenEnDatatypes.Optellen();
            // VariabelenEnDatatypes.VerbruikWagen();
            // StringsEnHunMethoden.StringsEnHunHoofdletters();
            // StringsEnHunMethoden.BerekenBtw();
            // StringsEnHunMethoden.leetSpeak();
            // StringsEnHunMethoden.Instructies();
            // StringsEnHunMethoden.Lotto();
            // Beslissingen.Schoenenverkoper();
            // Beslissingen.EvenOneven();
            // Beslissingen.BMIBerekenaar();
            // HoofdMenu();
            // Loops.CountDown();
            // Loops.Wachtwoord();
            // Loops.Gemiddelde();
            // Loops.Feestje();
            // Loops.RNATranscriptie();
            // Loops.VanMin100Tot100();
            // Loops.EenTafel();
            // Loops.PriemChecker();
            // Arrays.Arrayoefening();
            Arrays.ArrayOefener();
        }

        public static void HoofdMenu()
        {
            Console.WriteLine("Welke hoofdstuk kies je?");
            Console.WriteLine("1 - Hoofdstuk 1 - Werken met visual studio");
            Console.WriteLine("2 - Hoofdstuk 2 - Variabelen en datatypes");
            Console.WriteLine("3 - Hoofdstuk 3 - Strings en hun methoden");
            Console.WriteLine("4 - Hoofdstuk 4 - Beslissingen");
            Console.WriteLine("5 - Hoofdstuk 5 - Loops");
            int keuze = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (keuze)
            {
                case 4:
                    Beslissingen.KeuzeMenu();
                    break;
            }
        }
    }
}