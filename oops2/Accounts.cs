public abstract class Accounts
{
    //using 'prop' and then hitting tabs creates the boilerplate like this
    ///this creates the variables at the time of compilation
    //never supposed to use the variables anyways, so this is a shortcut
    public int accNo { get; set; }
    public string accName { get; set; }

    public double accBalance { get; set; }

    public string accCity { get; set; }

    public virtual double WithdrawMoney(int w_amount)
    {
        accBalance = accBalance - w_amount;
        return accBalance;

        //below is good practcie but ot needed with .net 2.0 and above
        //this.accBalance = this.accBalance - w_amount;
    }

    public double Deposit(int d_amount) {
        accBalance += d_amount;
        return accBalance;
    }
}