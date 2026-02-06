public static class PaymentFactory
{
    public static IPayment Create(string method)
    {
        return method switch
        {
            "CreditCard" => new CreditCardPayment(),
            "Paypal" => new PaypalPayment(),
            _ => throw new ArgumentException("Invalid payment method")
        };
    }
}
