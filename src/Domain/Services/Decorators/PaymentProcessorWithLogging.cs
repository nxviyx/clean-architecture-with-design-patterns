
public class PaymentProcessorWithLogging : IPaymentProcessor
{
    private readonly IPaymentProcessor _innerProcessor;
    private readonly ILogger _logger;

    public PaymentProcessorWithLogging(IPaymentProcessor innerProcessor, ILogger logger)
    {
        _innerProcessor = innerProcessor;
        _logger = logger;
    }

    public async Task<PaymentResult> ProcessPayment(Payment payment)
    {
        _logger.LogInformation("Starting payment processing...");
        var result = await _innerProcessor.ProcessPayment(payment);
        _logger.LogInformation($"Payment Result: {result.Message}");
        return result;
    }
}
