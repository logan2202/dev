using System;

namespace projet_8
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("renseigez votre age :") ;
            int a;
            a = int.Parse(Console.ReadLine());

            if (a >= 18) { 
            Console.WriteLine($"Vous avez {a} ans, vous êtes donc majeure.");
            }


            else { 
            Console.WriteLine($"Vous avez {a} ans, vous êtes donc mineure.");
            }
                
        }
    }
}
