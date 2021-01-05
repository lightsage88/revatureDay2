public class Loan : Accounts
{
    public override double WithdrawMoney(int w_amount)
    {
        if(w_amount > 500) 
        {
            //We are supposed to throw an exception
            //System.Console.WriteLine("Sorry, limit cann't exceed 250"); <- This is not a good practice
            //We should use exceptionhandling
            return accBalance;
        } else 
        {
            return base.WithdrawMoney(w_amount);
        }
    }
}
