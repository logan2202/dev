using System;

namespace projet_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            string p;
            DateTime date =DateTime.Today;

            //ren seignez son nom
            Console.WriteLine("entrez votre nom de famille:");
            n = Console.ReadLine();

            //renseignez son prenom
            Console.WriteLine("entrez votre prenom:");
            p = Console.ReadLine();

            Console.WriteLine($"bonjour {n} {p}, nous somme le {date.ToShortDateString()}, comment ca va ?");
            





        }
    }
}
