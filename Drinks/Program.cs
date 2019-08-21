using System;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<5) { 

            Console.WriteLine("Velkommen til baren");
            Console.WriteLine("Vi har 5 specialt lavet drinks");
            Console.WriteLine("Vodka: V");
            Console.WriteLine("Isbjørg: I");
            Console.WriteLine("Filur: F");
            Console.WriteLine("Sex on the beach: S");
            Console.WriteLine("Rom: R");
            string valg = Console.ReadLine();

                switch (valg.ToLower())
                {
                    case "v":
                        Console.WriteLine("Prisen er 50 kr");
                        break;
                    case "i":
                        Console.WriteLine("Prisen er 55 kr");
                        break;
                    case "f":
                        Console.WriteLine("Prisen er 23 kr");
                        break;
                    case "s":
                        Console.WriteLine("Prisen er 33 kr");
                        break;
                    case "r":
                        Console.WriteLine("Prisen er 25 kr");
                        break;
                    default:
                        Console.WriteLine("Du har ikke valgt en gyldig drink");
                        break;

                        
                }
            }i++;
        }
    }
}
