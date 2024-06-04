namespace Factory_SimpleFactory;


/// <summary>
/// This is a simple way of implementing the factory pattern
/// This example breaks OCP because the Factory class will have to be changed when adding a new payment method
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        IPayment cardPayment = PaymentFactory.Create(PaymentMethod.Card);
        cardPayment.Pay(30);
        
        IPayment cashPayment = PaymentFactory.Create(PaymentMethod.Cash);
        cashPayment.Pay(50);
    }
}