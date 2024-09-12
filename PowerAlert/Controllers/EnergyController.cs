using MediatR;
using Microsoft.AspNetCore.Mvc;
using PowerAlert.MediatR;
using PowerAlert.Observer;

namespace PowerAlert.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnergyController : ControllerBase
{
    private readonly EnergyObserverSubject _energyObserverSubject;

    public EnergyController(EnergyObserverSubject energyObserverSubject)
    {
        _energyObserverSubject = energyObserverSubject;
    }

    [HttpPost("update-energy")]
    public IActionResult UpdateEnergy([FromBody] EnergyData data)
    {
        _energyObserverSubject.UpdateEnergyData(data);
        return Ok("Energy data updated and observers notified.");
    }
}