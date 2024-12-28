
[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IMediator _mediator;

    public PaymentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("process")]
    public async Task<IActionResult> ProcessPayment([FromBody] Payment payment)
    {
        var result = await _mediator.Send(new ProcessPaymentCommand { Payment = payment });
        return Ok(result);
    }
}
