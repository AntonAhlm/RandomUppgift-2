using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många tärningar vill du kasta? ");
            int AntalTärning = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hur många sidor ska en tärning ha? ");
            int AntalSida = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hur många gånger vill du kasta tärningarna? ");
            int AntalKast = Convert.ToInt32(Console.ReadLine());

            Random slump = new Random();

            for(int i = 1; i<=AntalKast;i++)
            {
                Console.WriteLine("\n Kast " + i + " : ");
                for(int j = 1; j<=AntalTärning;j++)
                {
                    Console.WriteLine("Tärning " + j + " = " + slump.Next(1, AntalSida + 1));

                }

            }

        }
    }
}
