public class CreditCardPaymentCreator : PaymentCreator
{
    public override IPayment CreatePayment()
        => new CreditCardPayment();
}
