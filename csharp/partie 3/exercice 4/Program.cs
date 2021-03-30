using System;

namespace exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int mistere = aleatoire.Next(0, 50);
            int reponce = 0;
            int compteur = 0;
            while (reponce != mistere)
            {
                Console.WriteLine("trouver le nombre entre 0 et 50 ");
                reponce = int.Parse(Console.ReadLine());
                //incrémentation
                compteur++;
                if (reponce > mistere)
                {
                    Console.WriteLine("C’est plus petit");
                }
                else if (reponce < mistere)
                {
                    Console.WriteLine("C’est plus grand");
                }
            }
            Console.WriteLine("Bravo vous avez trouvé !");
            Console.WriteLine($"vous avez tenter {compteur} fois");
        }
    }
}
