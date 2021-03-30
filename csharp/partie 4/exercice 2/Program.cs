using System;
using System.Collections.Generic;

namespace exercice_2
{
    class Program
    {  
            static void Main(string[] args)
            {
            List<string> langague =new List<string>(); 
                langague.Add("HTML");
                langague.Add("CSS");
                langague.Add("javacrit");
                langague.Add("jquery");
                langague.Add("PHP");
                langague.Add("bootstrap");
                langague.Add("java");

            foreach (string o in langague)
            {
                Console.WriteLine(o);
                // ecrie sur la ligne
                //Console.Write(o + " ");
            }

            Console.WriteLine(langague[3]);

            Console.WriteLine(langague[4]);
            //supprime via le texte
            langague.Remove("bootstrap");
            //supprime via l'index
            //langague.RemoveAt(5);

            langague[2] = "Javascript";

            langague.Add("c");

            foreach (string o in langague)
            {
                Console.WriteLine(o.ToString());
            }
        }    
    }
}
