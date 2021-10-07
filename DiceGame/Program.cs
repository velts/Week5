using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mangu voitnud. Palju onne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mangu voitnud.");
                    cpuScore = cpuScore + 1;
                }
            }

        }
    }
}
