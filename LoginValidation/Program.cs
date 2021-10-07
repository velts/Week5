using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool:");
                string userPassword = Console.ReadLine();
                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;

                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale kasutajatunnus või parool. Sul on veel {3 - i} katset");
                }
            }
        }
    }
}
