public class CreditCardCreator : PaymentCreator
{
    public override IPayment CreatePayment()
        => new CreditCardPayment();
}
