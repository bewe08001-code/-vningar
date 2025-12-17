using System;
using System.IO;

namespace BlackJack
{
    class Program
    {   
    static string lastwinner = "ingen";
    static int pengar = 100;
    static string HighScoreFile = "highscore.txt";

    // kommer inte fungera om man inte har ett highscore.txt dokument //
    static int LoadHighScore()
    {
        try
        {
            if (!File.Exists(HighScoreFile)) return 0;
            var text = File.ReadAllText(HighScoreFile).Trim();
            if (int.TryParse(text, out int v)) return v;
        }
        catch { }
        return 0;
    }

    static void SaveHighScore(int value)
    {
        try
        {
            File.WriteAllText(HighScoreFile, value.ToString());
        }
        catch { }
    }
        static void Main(string[] args)
        {   
            if (Program.pengar <= 0)
            {
                Console.WriteLine("Du har inga pengar kvar att spela för, spelet avslutas.");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
            if (Program.lastwinner == "ingen")
            {

                Console.WriteLine("Välkommen till BlackJack!");
                Console.WriteLine("Vill du spela BlackJack? (ja)");
            }
            else
            {
                Console.WriteLine($"Vill du spela igen? (ja) Du har {Program.pengar} pengar.");
            }
            Console.WriteLine("Eller vill du veta vem som van förra rundan? (last)");
            Console.WriteLine("Eller vill du veta reglerna? (rules)");
            Console.WriteLine("Vill du se highscoren? (hs)");
            Console.WriteLine("Eller vill du avsluta? (avsluta)");
            String abc = Console.ReadLine().ToLower();
            if (abc == "hs"){
                int hs = LoadHighScore();
                Console.WriteLine("Det förra highscoren är: "+ hs);
                System.Threading.Thread.Sleep(2000);
                Main(args);
            }
            if (abc == "rules")
            {
                Console.WriteLine("Regler (för detta program):");
Console.WriteLine(@"
Du och datorn får två kort var. Datorn visar bara ett av sina kort i början.
Klädda kort (knekt, dam, kung) räknas som 10, och ess räknas som 11 
(men spelaren kan få det justerat till 1 om poängen annars blir över 21).
Målet är att få en total poäng så nära 21 som möjligt utan att gå över.
Efter dina två startkort kan du välja att dra fler kort eller stanna.
Om du går över 21 förlorar du direkt.
När du stannar drar datorn kort tills den har minst 17 poäng.
Den som har högst poäng utan att gå över 21 vinner.
Programmet sparar också vem som vann senaste rundan.
Du kan spara din highscore genom att avsluta speler när du har pengar kvar!
");
                System.Threading.Thread.Sleep(7500);
                Main(args);
            }
            else if (abc == "last")
            {
                Console.WriteLine(Program.lastwinner);
                System.Threading.Thread.Sleep(1000);
                Main(args);
            }
            else if (abc == "ja")
            {
                int insats = 0;
                while (true)
                {
                    Console.WriteLine($"Skriv in din insats (du har {Program.pengar}):");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int parsed))
                    {
                        Console.WriteLine("Ange ett giltigt heltal.");
                        continue;
                    }
                    insats = parsed;

                    if (insats == 0)
                    {
                        Console.WriteLine("Då satsar du inget.");
                        break;
                    }
                    else if (insats < 0)
                    {
                        Console.WriteLine("Insatsen kan inte vara negativ, försök igen.");
                        continue;
                    }
                    else if (insats > Program.pengar)
                    {
                        Console.WriteLine("Du har inte så mycket pengar, försök igen.");
                        continue;
                    }
                    else
                    {
                        Program.pengar -= insats;
                        Console.WriteLine($"Du satsade {insats}, du har nu {Program.pengar} pengar kvar.");
                        break;
                    }
                }
                
                int spelarensP = 0;
                int datornsP = 0;
                Random rand = new Random();
                int x = rand.Next(1, 14); if (x >= 11) x = 10; if (x == 1) x = 11;
                int y = rand.Next(1,14); if (y >= 11) y = 10; if (y == 1) y = 11;
                int z = rand.Next(1, 14); if (z >= 11) z = 10; if (z == 1) z = 11;   
                int w = rand.Next(1, 14); if (w >= 11) w = 10; if (w == 1) w = 11;
                if (w + z == 22)
                {
                    z = 1;
                }
                if (x + y == 22)
                {
                    y = 1;
                }
               
                spelarensP = x + y;
                datornsP = w + z;
                Console.WriteLine($"Du drog {x} och {y}, din poäng är {spelarensP} datorn har {w} poäng och ett kort gömt");
                if (datornsP == 21 && spelarensP == 21)
                {
                    Console.WriteLine($"Datorns gömda kort var {z}, båda fick BlackJack, oavgjort!");
                    Program.lastwinner = "Oavgjort!";
                    Program.pengar += insats;
                    Main(args);
                }
                else if (spelarensP == 21)
                {
                    Console.WriteLine("BlackJack! Du vann!");
                    Program.lastwinner = "Spelaren vann!";
                    Program.pengar += insats * 5/2;
                    Main(args);
                }
                else if (datornsP == 21)
                {
                    Console.WriteLine($"Datorns gömda kort var {z}, datorn fick BlackJack och vann!");
                    Program.lastwinner = "Datorn vann!";
                    Main(args);
                }
                bool sant = true;
                while (sant){
                Console.WriteLine("Vill du dra ett kort till? (ja/nej)");
                if (Console.ReadLine().ToLower() == "ja")
                {
                    int a = rand.Next(1, 14); if (a >= 11) a = 10;
                    spelarensP += a;
                    if (spelarensP > 21 && x == 11){
                        x = 1;
                        spelarensP -= 10;
                    }
                    else if (spelarensP > 21)
                    {
                        Console.WriteLine($"Du drog {a}, din poäng är nu {spelarensP}");
                        Console.WriteLine("Du gick över 21, du förlorade!");
                        Program.lastwinner = "Datorn vann!";
                        System.Threading.Thread.Sleep(1000);
                        sant = false;
                        Main(args);
                    }
                    Console.WriteLine($"Du drog {a}, din poäng är nu {spelarensP}");
                }
                else
                {
                    sant = false;
                }
                }
                Console.WriteLine($"Datorns gömda kort var {w}, datorns poäng är {datornsP}");
                System.Threading.Thread.Sleep(1000);
                while (datornsP < 17)
                {
                    int b = rand.Next(1, 14); if (b >= 11) b = 10;
                    datornsP += b;
                    Console.WriteLine($"Datorn drog {b}, datorns poäng är nu {datornsP}");
                }
                if (spelarensP > datornsP || datornsP > 21)
                {
                    Console.WriteLine("Du vann!");
                    System.Threading.Thread.Sleep(1000);
                    Program.lastwinner = "Spelaren vann!";
                    Program.pengar += insats * 2;
                }
                else if (spelarensP < datornsP)
                {
                    Console.WriteLine("Datorn vann!");
                    System.Threading.Thread.Sleep(1000);
                    Program.lastwinner = "Datorn vann!";
                }
                else
                {
                    Console.WriteLine("Oavgjort!");
                    System.Threading.Thread.Sleep(1000);
                    Program.lastwinner = "Oavgjort!";
                    Program.pengar += insats;
                }

                Main(args);


            }
            else if (abc == "avsluta")
            {
                Console.WriteLine("Okej, ha en bra dag!");
                try
                {
                    int current = Program.pengar;
                    int hs = LoadHighScore();
                    if (current > hs)
                    {
                        SaveHighScore(current);
                        Console.WriteLine($"Ny highscore sparad: {current}");
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                catch { }

                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Skriv någonting giltigt!");
                Main(args);
            }
        }
    }
}
