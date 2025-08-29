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
                    Console.WriteLine("\" \\ / \n \t");
            
            }
            else
            {
                Console.WriteLine("Okej, vi ses!");
            }
        }
    }
}
