// OOP/AbstractionExample.cs

public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

public class PayPalProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}

class Abstraction
{
    static void Main()
    {
        PaymentProcessor processor = new PayPalProcessor();
        processor.ProcessPayment(250);
    }
}
