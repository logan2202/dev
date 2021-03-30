using System;
using System.Collections.Generic;

namespace Projet
{
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class Program
    {

        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Good GF; Bad BF; 
            starter start;
            start = new starter();
            int score = 0;
            Console.Write("\r\n\t\tBonjour ! \r\n\r\n\tVous allez participer à un quizz de 10 Questions (1 seule bonne réponse par question)," +
                "\r\n\tdès que vous êtes prêt appuyez sur une touche pour commencer.");
            Console.Write("\t"); Console.ReadKey();
            Console.Clear();

            ////////////////////////////////////////////////////////

            string restart = "oui";
            int answer;

            ////////////////////////////////////////////////////////

            List<string> quizz = new List<string>()
            {
             "\r\n\t\tQui a crée le C# ? (Selectionnez 1,2,3 ou 4) \r\n\r\n\n\r\t 1/Microsoft \t 2/Comcast \t 3/Yahoo \t 4/Google\r\n\r\n",

            "\r\n\t\tQuelle est la date de sortie du C#? (Selectionnez 1,2,3 ou 4) \n\r\r\n\r\n\t 1/ 2000 \t 2/ 2001 \t 3/ 2002 \t 4/ 2003\r\n\r\n",

            "\r\n\t\tA quoi sert Microsoft Visual Studio ? (Selectionnez 1,2,3 ou 4) \n\r\r\n\r\n\t 1/ A rien \t 2/ Développement en mode logiciel" +
            "\t 3/ Microsoft Visual Studio \t 4/ Kouisine\r\n\r\n",

            ////////////////////////////////////////////////////////

            "\r\n\t\tDe quel langage est dérivé C# ? (Selectionnez 1,2,3 ou 4) \n\r\r\n\r\n\t 1/ CSS \t 2/ HTML \t 3/ C++ \t 4/ Java\r\n\r\n",

            "\r\n\t\tCombien de type de variables existent en C#? (Selectionnez 1,2,3 ou 4) \r\n\r\n\n\r\t 1/14 \t 2/ 13 \t 3/ 16 \t 4/ 15\r\n\r\n",

            "\r\n\t\tQuelle est la dernière version de C# sortie ? (Selectionnez 1,2,3 ou 4) \r\n\r\n\n\r\t 1/ 9.0 \t 2/ 8.0 \t 3/ 10.0 \t 4/ 9.5\r\n\r\n",

            ////////////////////////////////////////////////////////

                "\r\n\t\tComment assigner une valeur à une variable int ? (Selectionnez 1,2,3 ou 4) \r\n\r\n\r\n\t" +
                "1/ Int number = 0; \t 2/ int number = 0; \t 3/ int number = 0 \t 4/ int number;\r\n\r\n",

                "\r\n\t\tComment peut-on construire la variable foreach d'une fonction string ? (Selectionnez 1,2,3 ou 4) \r\n\r\n\t" +
                "1/ foraech (string fonction in function){} \t 2/ foreach (int fonction in function){} \r\n" +
                "\r\n\t3/ foreach (0 in <function>){} \t 4/ foreach (string fonction in function){}\r\n\r\n",

                "\r\n\t\tComment créer-t-on une classe public ? (Selectionnez 1,2,3 ou 4) \r\n\r\n\r\n\t" +
                "1/ Public class new{Public new{}} \t 2/ public class new;{public new{};}; " +
                "\r\n\r\n\t 3/ public new{public class new{}} \t 4/ private class new{private new{}}\r\n\r\n",

                "\r\n\t\tEn quel langue à était fait le language C# ? (Selectionnez 1,2,3 ou 4) \r\n\r\n\r\n\t" +
                "1/ englais \t 2/ anglai \t 3/ Angais  \t 4/ anglais \r\n\r\n"
            };

            ////////////////////////////////////////////////////////

            while (restart == "oui")
            {
                score = 0;
                Console.WriteLine(quizz[0]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(quizz[1]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 2)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(quizz[2]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 2)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();
                ////////////////////////////////////////////////////////

                Console.WriteLine(quizz[3]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 3)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(quizz[4]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 4)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(quizz[5]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();
                ////////////////////////////////////////////////////////

                Console.WriteLine(quizz[6]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 2)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(quizz[7]);
                Console.WriteLine("\r\nDonner la bonne réponse :");
                Console.Write("\t"); answer = int.Parse(Console.ReadLine());
                if (answer == 4)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(quizz[8]);
                Console.Write("\t"); Console.WriteLine("\r\nDonner la bonne réponse :");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(quizz[9]);
                Console.Write("\t"); Console.WriteLine("\r\nDonner la bonne réponse :");
                answer = int.Parse(Console.ReadLine());
                if (answer == 4)
                {
                    GF = new Good();
                    Console.WriteLine("Vous avez la bonne réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                    score++;
                }
                else
                {
                    BF = new Bad();
                    Console.WriteLine("Mauvaise réponse !\r\n\r\nAppuyez sur une touche pour continuer...");
                }
                Console.ReadKey();
                Console.Clear();
                ////////////////////////////////////////////////////////

                Console.WriteLine($"\r\n\r\n\r\n\r\n\r\n\t\tVous avez {score} de bonnes réponses !");
                Console.WriteLine("\r\n\t\tVous voulez recommencer ? (oui/non)");
                restart = Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
