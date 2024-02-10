namespace Lab4;

class Lab4
{
    static void Main(string[] args)
    {
        Checking c1 = new Checking();
        Savings s1 = new Savings();
        bool exit = false;
        
        while (!exit)
        {
            Console.WriteLine("1. Withdraw from Checking" +
                              "\n2. Withdraw from Savings" +
                              "\n3. Deposit to Checking" +
                              "\n4. Deposit to Savings" +
                              "\n5. Balance of Checking" +
                              "\n6. Balance of Savings" +
                              "\n7. Award Interest to Savings now" +
                              "\n8. Quit");
            int.TryParse(Console.ReadLine(), out int uInput);
            switch (uInput)
            {
                case 1:
                    Console.WriteLine("How much would you like to withdraw from Checking?");
                    decimal.TryParse(Console.ReadLine(), out decimal a1);
                    c1.Withdraw(a1);
                    break;
                case 2:
                    Console.WriteLine("How much would you like to withdraw from Savings?");
                    decimal.TryParse(Console.ReadLine(), out decimal a2);
                    s1.Withdraw(a2);
                    break;
                case 3:
                    Console.WriteLine("How much would you like to deposit into Checking?");
                    decimal.TryParse(Console.ReadLine(), out decimal a3);
                    c1.Deposit(a3);
                    break;
                case 4:
                    Console.WriteLine("How much would you like to deposit into Savings?");
                    decimal.TryParse(Console.ReadLine(), out decimal a4);
                    s1.Deposit(a4);
                    break;
                case 5:
                    Console.WriteLine($"Your balance for checking {c1.accountNumber} is {c1.accountBalance:C2}");
                    break;
                case 6:
                    Console.WriteLine($"Your balance for savings {s1.accountNumber} is {s1.accountBalance:C2}");
                    break;
                case 7:
                    s1.AddInterest();
                    break;
                case 8:
                    exit = true;
                    break;
            }
        }
        
    }
}