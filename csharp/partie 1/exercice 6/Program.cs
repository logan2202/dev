using System;

namespace projet_6
{
    class Program
    {
        static void Main(string[] args)
        {// renseignez son nom
            string n;   
            Console.WriteLine("entrez vore nom:");
            n = Console.ReadLine();
            //renseignez son prenom
            string p;
            Console.WriteLine("entrez votre prenom:");
            p = Console.ReadLine();
            //renseignez son annee de naissance 
            int a;
            Console.WriteLine("entrez votre annee de naissance:");
            a = int.Parse(Console.ReadLine());

            //calculer l'age 
            DateTime date = DateTime.Today;
            int age = date.Year - a;

            //saut de ligne
            string s = "\r\n";

            Console.WriteLine($"fiches de renseignement: {s} *nom: {n} {s} *prenom: {p} {s} *age: {age}");
            
            

        }
    }
}
