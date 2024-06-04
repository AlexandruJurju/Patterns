namespace Factory_SimpleFactory;

public class CardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} with card");
    }
}