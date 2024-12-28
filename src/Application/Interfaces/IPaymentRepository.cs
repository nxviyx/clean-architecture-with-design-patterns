
public interface IPaymentRepository
{
    Task AddPaymentAsync(Payment payment);
    Task<IEnumerable<Payment>> GetPaymentsAsync();
}
