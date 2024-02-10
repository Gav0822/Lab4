namespace Lab4;

public class Savings : Account
{
    private int numOfDeposits = 1;
    private decimal fee = 10m;
    
    public Savings()
    {
        accountNumber = base.accountNumber;
        accountBalance = 0;
    }
    
    public Savings(decimal balance)
    {
        accountNumber = base.accountNumber;
        accountBalance = balance;
    }

    public override void Withdraw(decimal deduction)
    {
        decimal minimum = 500m;
        if (accountBalance - deduction < minimum)
        {
            Console.WriteLine($"Charging a fee of {fee:C0} because you are below {minimum:C0}");
            base.Withdraw(deduction + fee);
        }
        else 
            base.Withdraw(deduction);
    }

    public override void Deposit(decimal addition)
    {
        if (numOfDeposits < 6)
        {
            Console.WriteLine($"This is deposit {numOfDeposits} to this account.");
            base.Deposit(addition);
            numOfDeposits++;
        }
        else
        {
            Console.WriteLine($"Charging a fee of {fee:C0}.");
            base.Deposit(addition - fee);
        }
    }

    public void AddInterest()
    {
        decimal accruedInterest = (0.015m * accountBalance);
        Console.WriteLine($"Customer earned {accruedInterest:C2} in interest.");
        accountBalance += accruedInterest;
    }
}