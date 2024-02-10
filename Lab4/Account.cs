namespace Lab4;

public class Account
{
    public static int baseNum = 10001;

    public int accountNumber { get; set; }
    public decimal accountBalance { get; set; }

    public Account()
    {
        accountNumber = baseNum;
        baseNum++;
        accountBalance = 0;
    }
    
    public Account(decimal balance)
    {
        accountNumber = baseNum;
        baseNum++;
        accountBalance = balance;
    }

    public virtual void Withdraw(decimal deduction)
    {
        accountBalance -= deduction;
    }

    public virtual void Deposit(decimal addition)
    {
        accountBalance += addition;
    }
}