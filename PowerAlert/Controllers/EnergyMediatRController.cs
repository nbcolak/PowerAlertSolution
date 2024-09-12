using MediatR;
using Microsoft.AspNetCore.Mvc;
using PowerAlert.MediatR;
using PowerAlert.Observer;

namespace PowerAlert.Controllers;
[ApiController]
[Route("api/[controller]")]
public class EnergyMediatRController: ControllerBase
{
    private readonly IMediator _mediator;

    public EnergyMediatRController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("update-energy")]
    public async Task<IActionResult> UpdateEnergy([FromBody] EnergyData data)
    {
        await _mediator.Publish(new EnergyConsumptionExceeded(data.Consumption, data.Threshold));
        return Ok("Energy data updated and observers notified.");
    }
    
}