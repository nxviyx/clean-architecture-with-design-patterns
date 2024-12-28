
using MediatR;

public class ProcessPaymentCommandHandler : IRequestHandler<ProcessPaymentCommand, PaymentResult>
{
    private readonly Func<string, IPaymentProcessor> _paymentProcessorFactory;

    public ProcessPaymentCommandHandler(Func<string, IPaymentProcessor> paymentProcessorFactory)
    {
        _paymentProcessorFactory = paymentProcessorFactory;
    }

    public async Task<PaymentResult> Handle(ProcessPaymentCommand request, CancellationToken cancellationToken)
    {
        var processor = _paymentProcessorFactory(request.Payment.Method);
        return await processor.ProcessPayment(request.Payment);
    }
}
