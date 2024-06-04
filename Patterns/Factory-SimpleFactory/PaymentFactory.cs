namespace Factory_SimpleFactory;

/// <summary>
/// This class breaks OCP because when adding a new payment method the switch will have to be changed
/// Fix would be to have an abstract Factory class for each type of payment
/// </summary>
public class PaymentFactory
{
    public static IPayment Create(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.Card:
                return new CardPayment();
            case PaymentMethod.Cash:
                return new CashPayment();
            default:
                throw new Exception("No valid payment method");
        }
    }
}