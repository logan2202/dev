using System;

namespace exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string continues = "y";

            while (continues == "y") 
            {
            Console.WriteLine("ajouter un nombre");
            int number = int.Parse(Console.ReadLine());
            result += number;
            Console.WriteLine($"votre est {result}");
                Console.WriteLine("voulez vous contiuer ? y/n");
                continues = Console.ReadLine();
            }
            

        }
    }
}
