
using MediatR;

public class ProcessPaymentCommand : IRequest<PaymentResult>
{
    public Payment Payment { get; set; }
}
