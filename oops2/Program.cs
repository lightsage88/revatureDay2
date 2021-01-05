using System;

namespace oops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
//Old way
//             Accounts accObj = new Accounts();
//             accObj.accNo = 101;
// //accObj.accNo = 103; //this is an extra code
//             accObj.accName = "Nik";
//             accObj.accBalance = 6000;

//New Way
            // Accounts accObj = new Accounts(){accNo = 101, accName = "Nik", accBalance =3000, accCity = "Portland"};
            // System.Console.WriteLine("Current Balance : " + accObj.accBalance);
            // accObj.WithdrawMoney(300);



            Savings savingsObj = new Savings(){accNo = 101, accName="Steve", accCity="Paris", accBalance = 8000};
            Current currentObj = new Current(){accNo = 103, accName="Steve", accCity="Paris", accBalance = 8000};
            Loan    loanObj = new Loan(){accNo = 102, accName="Bill", accCity="Moscow", accBalance = 12000};

            Console.WriteLine(savingsObj.WithdrawMoney(300));
            Console.WriteLine(loanObj.WithdrawMoney(300));
        }
    }
}
