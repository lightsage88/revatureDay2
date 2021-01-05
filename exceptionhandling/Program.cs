using System;

namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings savObj = new Savings();
            savObj.accountBalance = 2000;
            savObj.accountBalance = -100;
            System.Console.WriteLine("Enter first number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter second number");
            int n2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                System.Console.WriteLine(savObj.DivideMyFavoriteNumber(n1, n2));

            }
            catch(DivideByZeroException exc) 
            {
                System.Console.WriteLine(exc.Message);
            }

            System.Console.WriteLine("Please enter the amount:");
            int amt = Convert.ToInt32(Console.ReadLine());
            try
            {
                System.Console.WriteLine(savObj.withdraw(amt));
            } 
            catch(Exception exc)
            {  
                System.Console.WriteLine(exc.Message);
            }
            finally
            {
                System.Console.WriteLine("Thanks for banking!");
            }
        
            System.Console.ReadLine();
        }
    }
}
