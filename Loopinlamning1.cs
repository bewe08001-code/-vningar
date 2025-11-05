using System;

namespace Loopinlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++) Console.WriteLine(a);

            Console.WriteLine("Skriv ett heltal:");
            while (true)
            {
                try
                {
                    int v = int.Parse(Console.ReadLine()!);
                    if (v == 0) break;
                    else Console.WriteLine("skriv ett annat tal");
                }
                catch { }
            }

            int sum = 0;
            Console.WriteLine("Mata in 5 heltal:");
            for (int b = 0; b < 5; )
            {
                try
                {
                    int x = int.Parse(Console.ReadLine()!);
                    sum += x;
                    b++;
                }
                catch { }
            }
            Console.WriteLine(sum);

            string pwd;
            do
            {
                Console.WriteLine("Skriv lösenord:");
                pwd = Console.ReadLine()!;
            } while (pwd != "hemligt");

            for (int c = 2; c <= 20; c += 2) Console.WriteLine(c);

            for (int d = 10; d >= 1; d--) Console.WriteLine(d);

            Console.WriteLine("Mata in positiva tal, skriv ett negativt tal för att avsluta:");
            while (true)
            {
                try
                {
                    int t = int.Parse(Console.ReadLine()!);
                    if (t < 0) break;
                }
                catch { }
            }

            int produkt = 1;
            for (int e = 1; e <= 5; e++) produkt *= e;
            Console.WriteLine(produkt);

            int rader = 4;
            for (int f = 1; f <= rader; f++)
            {
                for (int g = 0; g < f; g++) Console.Write("*");
                Console.WriteLine();
            }

            int evenCount = 0;
            Console.WriteLine("Mata in 10 heltal så säger jag hur många som är jämna av dom:");
            int hCount = 0;
            while (hCount < 10)
            {
                try
                {
                    int y = int.Parse(Console.ReadLine()!);
                    if (y % 2 == 0) evenCount++;
                    hCount++;
                }
                catch { }
            }
            Console.WriteLine($"{evenCount} var jämna tal.");
        }
    }
}
