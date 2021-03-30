using System;

namespace projet_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer un mois");
            String mois = Console.ReadLine();
            if (mois == "janvier" || mois == "fevrier" || mois == "decembre" || mois == "mars" || mois == "avril" || mois == "mai")
            {if (mois == "janvier" || mois == "fevrier" || mois == "decembre")
                {
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                }
                else
                {
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                }
            }
                    
                
                    
            else
            {
                if (mois == "juin" || mois == "juillet" || mois == "aout")
                {
                    Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
                }
                else
                {
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                }
            }
        }
    }
}
