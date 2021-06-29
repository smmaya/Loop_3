using System;

namespace Pętle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj liczbę wierszy: ");
            int wiersze = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj liczbę gwiazdek: ");
            int gwiazdki = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= wiersze; i++)
            {
                for (int j = 1; j <= gwiazdki; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
