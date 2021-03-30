using System;
using System.Collections.Generic;

namespace exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
                string answer = "y";
                while(answer != "n")
            {
                Console.WriteLine("veuiller multiplier un nombre");
                numbers.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("voulez vous ajputer un nombre ? y/n");
                answer = Console.ReadLine();
            }
                
                int count = 1;
            int result = 1;
            string calc = "";
            Console.WriteLine("calcul du produit des nombres de la liste");
            foreach (int number in numbers)
            {
                result *= number;
                if (count == numbers.Count)
                {
                    calc += number;
                }
                else
                {
                    calc += number + " x ";
                }
                count++;
            }
            Console.WriteLine($"{calc} = {result}");
        }
        }
    }

