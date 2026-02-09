internal sealed class FactoryMethodUsageExample
{
    public void Run()
    {
        PaymentCreator creator = new CreditCardPaymentCreator();
    }
}