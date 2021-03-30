using System;

namespace exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[7];
            week[0] = "lundi";
            week[1] = "mardi";
            week[2] = "mercredi";
            week[3] = "jedi";
            week[4] = "vendredi";
            week[5] = "samedi";

            Console.WriteLine(week[1]);
            Console.WriteLine(week[4]);

            Console.WriteLine(week[0]);
            Console.WriteLine(week[3]);

            week[3] = "jeudi";
            week[6] = "dimanche";
            Array.ForEach(week, Console.WriteLine);
            for (int index = 0; index < week.Length; index++)
            {
                Console.WriteLine(index + ": " + week[index]);
            }
            foreach (string day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
           

