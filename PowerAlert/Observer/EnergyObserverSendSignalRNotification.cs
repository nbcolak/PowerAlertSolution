using Microsoft.AspNetCore.SignalR;
using PowerAlert.SignalR;

namespace PowerAlert.Observer;

public class EnergyObserverSendSignalRNotification : IObserver
{
    private readonly IHubContext<NotificationHub> _hubContext;

    public EnergyObserverSendSignalRNotification(IHubContext<NotificationHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async void Update(EnergyData data)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveNotification", $"Energy consumption exceeded: {data.Consumption} > {data.Threshold}");
    }
}