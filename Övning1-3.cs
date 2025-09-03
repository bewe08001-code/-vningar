using System;
namespace Lektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hej och välkommen till min första C#-applikation!");
            Console.WriteLine("Jag kan skriva många saker vill du se? (y/n)");
            string svar = Console.ReadLine();
            if (svar == "y")
            {
                Console.Clear();
                Console.WriteLine("\" \\ /");
                Console.WriteLine("Vill du ha ett virus (det är ofarligt) (y/n)");
                string svar1 = Console.ReadLine();
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                if (svar1 == "y")
                {
                    Console.WriteLine("Grattis du har fått ett virus!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Du får ett ändå");
                    Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Nu är din dator blå med vita bokstäver");
                Console.WriteLine("Det betyder att du har fått ett virus");

                Console.WriteLine("Vill du även se en fin triangel? (y/n)");
                string svar2 = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                if (svar2 == "y")
                {
                    Console.WriteLine("   /\\   ");
                    Console.WriteLine("  /  \\  ");
                    Console.WriteLine(" /\" \" \\ ");
                    Console.WriteLine("/______\\");
                }
                else
                {
                }    
            }
            else
            {
                Console.WriteLine("Okej, vi ses!");
            }
        }
    }
}
