
public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public async Task<PaymentResult> ProcessPayment(Payment payment)
    {
        return new PaymentResult { IsSuccessful = true, Message = "Payment processed via Credit Card" };
    }
}
