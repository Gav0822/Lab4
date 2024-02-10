namespace Lab4;

public class Checking : Account
{
    
    public Checking()
    {
        accountNumber = base.accountNumber;
        accountBalance = 0;
    }
    public Checking(decimal balance)
    {
        accountNumber = base.accountNumber;
        accountBalance = balance;
    }

    public override void Withdraw(decimal deduction)
    { 
        decimal overdraftFee = 20m;
        if ((accountBalance - deduction) < 0)
        {
            Console.WriteLine($"Charging an overdraft fee of {overdraftFee:C0} because account is below $0");
            base.Withdraw(deduction + overdraftFee);
        }
        else
        {
            base.Withdraw(deduction);
        }
    }
}    
        
    