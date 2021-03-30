using System;

namespace programme_orienter_objets
{

    class Program
    {
        static void Main(string[] args)
        {

            Bank_account compteLaManu = new Bank_account
            {
                holder = "LaManu",
                balance = 2000,
                device = "euros"

            };
            compteLaManu.credit(19);
            Console.WriteLine($"le solde du compte de {compteLaManu.holder} est de {compteLaManu.balance} {compteLaManu.device}" );

        }
    }
}
