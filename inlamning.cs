using System;
using System.Collections.Generic;
using System.Globalization;
namespace inlamning
{
    class Vars
    {
        public List<string> Synonym = new List<string> { "sannerligen", "yes", "y", "ja", "jajemen", "okej", "javist", "sure", "absolut", "definitivt", "verkligen", "självklart", "naturligtvis", "givetvis", "visst", "javisst", "absolut", "definitivt", "verkligen", "självklart", "naturligtvis", "givetvis", "visst", "javisst", "of course", "certainly", "indeed", "affirmative", "roger", "aye", "yep", "yeah", "yup", "sure thing", "you bet", "gladly", "willingly", "enthusiastically" };
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vad är din favorit bok?");
            string bok = Console.ReadLine();
            Console.WriteLine($"Vad roligt! Jag gillar också {bok}.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("(tryck enter för att fortsätta)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Vill du fortsätta svara på frågor? (ja/nej)");
            string svar = Console.ReadLine();
            Vars v = new Vars();
            if (v.Synonym.Contains(svar))
            {
                Console.WriteLine("Vad kul!");
                Console.WriteLine("Det var en gång en elin och en alma som hoppade och elin hoppade lång och alma kort. snippsnappsnut och var sagan slut...");
                Console.WriteLine("Hur långt hoppade Elin? (svar i meter utan enhet)");
                string ehopp = Console.ReadLine().Replace(',', '.');

                Console.WriteLine("Oj så långt, hur långt hoppade alma?");
                string ahopp = Console.ReadLine().Replace(',', '.');
                double elin = double.Parse(ehopp, CultureInfo.InvariantCulture);
                double alma = double.Parse(ahopp, CultureInfo.InvariantCulture);
                double diff = elin - alma;

                Console.WriteLine($"Oj Elin hoppade {diff} längre än alma");
                Console.WriteLine("klicka enter för att fortsätta");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Nu har du hyrt en bil, hur många Kilometer ska du åka?");
                string kilom = Console.ReadLine();
                int km = int.Parse(kilom);
                Console.WriteLine("Hur många dagar har du hyrt bilen?");
                string dagar = Console.ReadLine();
                int dgr = int.Parse(dagar);
                int kostnad = km + ((dgr - 1) * 500) + 300;
                Console.WriteLine($"Din totala kostnad är {kostnad} kr");
                Console.WriteLine("Du kan Swisha mig direkt på 0733291665");
                Console.ReadLine();
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Sista frågan!");
                Console.WriteLine("Säg lönen för 3 medarbetare (en i taget) och jag ska säga medellönen");
                string lön1 = Console.ReadLine().Replace(',', '.');
                string lön2 = Console.ReadLine().Replace(',', '.');
                string lön3 = Console.ReadLine().Replace(',', '.');
                double l1 = double.Parse(lön1, CultureInfo.InvariantCulture);
                double l2 = double.Parse(lön2, CultureInfo.InvariantCulture);
                double l3 = double.Parse(lön3, CultureInfo.InvariantCulture);
                double medel = (l1 + l2 + l3) / 3;
                Console.WriteLine($"Medellönen är {medel:F2} kr");
            }
            else
            {
                Console.WriteLine("Okej, inga problem. Ha en bra dag!");
            }
        }
    }
}
