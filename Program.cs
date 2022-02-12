using System;

namespace HelloWorld
{
    class Program
    {
        int numberOfBranches = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Nuban ogechisNuban = new Nuban(327001318, 8);

            CustomerAccount customerAccount = new CustomerAccount();

            BankBranch isoloBranch = new BankBranch();
            isoloBranch.hqAddress = "36, Marina, Lagos";
            isoloBranch.bankName = "Union Bank";
            isoloBranch.name = "Isolo Branch";

            Bank bank = new Bank();

            //3270013188
            Console.WriteLine("Ogechi's Account number is: "+ ogechisNuban);
        }
    }
}
