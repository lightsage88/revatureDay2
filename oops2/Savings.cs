public class Savings : Accounts
{
    public override double WithdrawMoney(int w_amount)
    {
        if(w_amount > 250) 
        {
            //We are supposed to throw an exception
            System.Console.WriteLine("Sorry, limit cann't exceed 250");
            return accBalance;
        } else 
        {
            return base.WithdrawMoney(w_amount);
        }
    }
}