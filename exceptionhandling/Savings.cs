using System;
class Savings
{
    //properties
    // public double accountBalance {get; set;}
    
    private double acBal;
    public double accountBalance
    {
        get { return acBal; }
        set {
            if(value < 0) {
                throw new Exception("Balance cant be zero");
            } else {
                acBal = value;
            }
        }
    }
    public int DivideMyFavoriteNumber(int firstNumber, int secondNumber)
    {
        if(secondNumber == 0) {
            throw new DivideByZeroException("Cannot divide any number by zero, dog.");
        }
        return firstNumber / secondNumber;
    }

    public double withdraw(int amount) 
    {
        if(amount > accountBalance)
        {
            //we throw a new exception
            throw new System.Exception("Sorry, cannot withdraw because you lack sufficient funds.");
        }

        if(amount < 0) 
        {
            throw new System.Exception("Please only positive values");
        }

        if(amount < 0 || amount < 100) 
        {
            throw new System.Exception("Please enter amount greater than 100");
        }


        accountBalance = accountBalance - amount;
        return accountBalance;
    }
}