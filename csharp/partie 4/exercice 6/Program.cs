using System;


namespace exercice_6
{
   
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            Week myVar = Week.Lundi;
            Console.WriteLine(myVar);
            Week myVar2 = Week.Mardi;
            Console.WriteLine(myVar2);
            Week myVar3 = Week.Mercredi;
            Console.WriteLine(myVar3);
            Week myVar4 = Week.Jeudi;
            Console.WriteLine(myVar4);
            Week myVar5 = Week.Vendredi;
            Console.WriteLine(myVar5);
            Week myVar6 = Week.Samedi;
            Console.WriteLine(myVar6);
            Week myVar7 = Week.Dimanche;
            Console.WriteLine(myVar7);
            Week myVar8 = (Week)4;
            Console.WriteLine(myVar8);
        }
    }
}
