using System;

namespace projet_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("etrez votre age :(un chiffre)");
           int age = int.Parse(Console.ReadLine());
            Console.WriteLine("quel est votre sexe ? (m ou f)");
            string sexe = Console.ReadLine();
           if (sexe == "m")
            {
                if (age >= 18)
                {
                    Console.WriteLine(" Vous êtes un homme et vous êtes majeur");
                }
                else {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                }
   
            }     
            else
            {
                if (age >= 18)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure");
                }

                else
                {Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
                }
                    

            }
               



        }
    }
}
