
public interface IPaymentProcessor
{
    Task<PaymentResult> ProcessPayment(Payment payment);
}
