using System;

namespace projet_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = "logan";
            String password = "martin";
            Console.WriteLine("etrez votre nom d'utilisateur :");
            String u = Console.ReadLine();
            Console.WriteLine("etrez votre mot de passe :");
            String m = Console.ReadLine();

            if (u != login || m != password)
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }
            else
            {
                Console.WriteLine("bievenue à la manu !");
            }



        }
    }
}

