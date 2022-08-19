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

        public static void Boodschappenlijst() {
            Console.WriteLine("We gaan de boodschappenlijst samenstellen. Hoeveel items wil je opschrijven.");
            
            int aantal = Convert.ToInt32(Console.ReadLine());
            string[] items = new string[aantal];

            for (int i = 0; i < aantal; i++) {
                Console.WriteLine($"Wat is de item {i + 1} op je lijst?");
                items[i] = Console.ReadLine();
            }

            Array.Sort(items);
            Console.WriteLine("Dit is je gesorteerde lijst");

            for (int i = 0; i < items.Length; i++) {
                Console.WriteLine($"{i+1}: {items[i]}");
            }

            Console.WriteLine("Op naar de winkel?");
            string nogWinkelen = "ja";

            while (nogWinkelen.ToUpper() == "JA") {
                Console.WriteLine("Welk item heb je gekocht?");
                string item = Console.ReadLine();

                if (Array.BinarySearch(items,item)<0){
                    Console.WriteLine("Dit iten bevindt zich niet op de lijst!");
                } else {
                    items[Array.IndexOf(items,item)] = "gekocht";
                }

                Console.WriteLine("NOg winkelen? ja of nee?");
                nogWinkelen = Console.ReadLine();
            }
        }

        public static void Kerstinkopen() {
            Console.WriteLine("Wat is het budget voor je kerstinkopen?");
            double budget = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoeveel cadeautjes wil je kopen?");
            int aantal = Convert.ToInt32(Console.ReadLine());

            double[] cadeautjes = new double[aantal];

            for (int i = 0; i < aantal; i++) {
                Console.WriteLine($"Prijs van cadeau {i + 1}?");
                cadeautjes[i] = Convert.ToDouble(Console.ReadLine());
                if (cadeautjes.Sum() > budget){
                    Console.WriteLine($"Je bent al {(cadeautjes.Sum() - budget):F1} euro over het budget!");
                }
            }

            Console.WriteLine("Info over je aankopen :");
            Console.WriteLine($"Toaal bedrag: {cadeautjes.Sum():F1} euro.");
            Console.WriteLine($"Duurste cadeau: {cadeautjes.Max():F1} euro.");
            Console.WriteLine($"Goedkoopste cadeau: {cadeautjes.Min():F1} euro.");
            Console.WriteLine($"Gemiddelde prijs: {cadeautjes.Average():F1} euro.");
            Console.ReadKey();
        }

        public static void Lotto(){
            int[] lottoFormulier = new int[6];

            Console.WriteLine("Geef je lotto getallen (getallen moeten tussen 1 en 42 liggen).");
            int i;

            for (i = 0; i < lottoFormulier.Length; i++){
                Console.WriteLine("Geef lotto nummer " + (i + 1).ToString());
                lottoFormulier[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] lottoTrekking = new int[6];

            for (i = 0; i < lottoTrekking.Length; i++){
                lottoTrekking[i] = 0;
            }
            Random random = new Random();
            int lottoGetal;

            for (i = 0; i < lottoTrekking.Length; i++) {
                do
                {
                    lottoGetal = random.Next(42) + 1;
                }
                while (Array.IndexOf(lottoTrekking, lottoGetal) >= 0);
                lottoTrekking[i] = lottoGetal;
            }

            int aantalJuisteGetallen = 0;
            for (i = 0; i <= 5; i++){
                if (Array.IndexOf(lottoTrekking, lottoFormulier[i]) >= 0){
                    aantalJuisteGetallen += 1;
                }
            }

            int gewonnenBedrag = 0;
            if (aantalJuisteGetallen == 3){
                gewonnenBedrag = 10;
            }
            else if (aantalJuisteGetallen == 4){
                gewonnenBedrag = 1000;
            }
            else if (aantalJuisteGetallen == 5){
                gewonnenBedrag = 100000;
            }
            else if (aantalJuisteGetallen == 6){
                gewonnenBedrag = 100000000;
            }
            else{

            }

            Array.Sort(lottoFormulier);
            Array.Sort(lottoTrekking);

            Console.WriteLine("Je gekowen cijfers zijn:");
            for (i = 0; i < lottoFormulier.Length; i++){
                Console.Write($"{lottoFormulier[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("De trekking cijfers zijn:");
            for (i = 0; i < lottoTrekking.Length; i++){
                Console.Write($"{lottoTrekking[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Je hebt {gewonnenBedrag} Euro gewonnen.");
            Console.ReadKey();
        }

        public static void IntegerIndexOf(){
            int[] getallen = new int[10];
            int i;
            int index;

            Console.WriteLine("Geef 10 willekeurige gehele getallen");
            for (i = 0; i < getallen.Length; i++){
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Welke geheel getal wil je zoeken?");
            int zoekWaarde = Convert.ToInt32(Console.ReadLine());

            i=0;
            index = -1;

            do{
                if (getallen[i] == zoekWaarde){
                    index = i;
                }
                i++
            } while (i < getallen.Length && index == -1);
            if (index == -1){
                Console.WriteLine($"Je zocht {zoekWaarde}, jammer die is niet gevonden.");
            } else {
                Console.WriteLine($"Je zocht {zoekWaarde}, die is gevonden op index {index}.");
            }
            Console.ReadKey();
        }

        public static void StringBinarySearch() {
            string[] autoMerken = {
                "Citroen",
                "Mercedes",
                "Peugeot",
                "BMW",
                "Toyota",
                "AstonMartin",
                "Ferrari",
                "Opel",
                "Lexus",
                "Wartburg"
            };

            int beginIndex = 0;
            int eindIndex = autoMerken.Length - 1;
            int middenIndex;
            int index = -1;

            Console.WriteLine("Welke automerk wil je zoeken?");
            string zoekWaarde = Console.ReadLine();

            Array.Sort(autoMerken);
            while (beginIndex <= eindIndex)
            {
                middenIndex = beginIndex + (eindIndex - beginIndex) / 2;
                if (autoMerken[middenIndex].CompareTo(zoekWaarde) < 0){
                    beginIndex = middenIndex + 1;
                }
                else if (autoMerken[middenIndex].CompareTo(zoekWaarde) > 0)
                {
                    eindIndex = middenIndex - 1;
                }
                else
                {
                    index = middenIndex;
                    beginIndex = eindIndex + 1;
                }
            }
             if (index == -1)
            {
                Console.WriteLine($"Je zocht {zoekWaarde}, jammer die is niet gevonden");
            }
            else
            {
                Console.WriteLine($"Je zocht {zoekWaarde}, die is gevonden op index {index}");
            }
            Console.ReadKey();
        }
    }
}