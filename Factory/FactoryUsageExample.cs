internal sealed class FactoryUsageExample
{
    public void DemonstrateFactoryUsage()
    {
        IPayment payment1 = PaymentFactory.Create("CreditCard");
        payment1.Pay(100.0m);

        IPayment payment2 = PaymentFactory.Create("Paypal");
        payment2.Pay(200.0m);
    }
}