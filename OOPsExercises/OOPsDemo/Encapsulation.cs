// OOP/EncapsulationExample.cs

// Encapsulation: Hiding internal data using properties.
public class BankAccount
{
    private decimal _balance; // private field

    public string AccountHolder { get; set; }

    public decimal Balance
    {
        get { return _balance; }
        private set { _balance = value; }
    }

    public BankAccount(string name, decimal initialDeposit)
    {
        AccountHolder = name;
        _balance = initialDeposit;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
            Console.WriteLine("Insufficient balance.");
        else
        {
            _balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New balance: {_balance}");
        }
    }
}

class Encapsulation
{
    static void Main()
    {
        var account = new BankAccount("Alice", 500);
        account.Deposit(200);
        account.Withdraw(100);
    }
}
