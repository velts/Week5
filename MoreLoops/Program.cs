using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            string userPassword = Console.ReadLine();

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere Tulemast!");

            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");

            }


        }
    }
}
