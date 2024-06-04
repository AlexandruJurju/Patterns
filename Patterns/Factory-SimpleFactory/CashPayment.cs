namespace Factory_SimpleFactory;

public class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} with cash");
    }
}