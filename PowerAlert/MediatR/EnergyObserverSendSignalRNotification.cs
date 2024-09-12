using MediatR;
using Microsoft.AspNetCore.SignalR;
using PowerAlert.SignalR;

namespace PowerAlert.MediatR;

public class EnergyObserverSendSignalRNotification : INotificationHandler<EnergyConsumptionExceeded>
{
    private readonly IHubContext<NotificationHub> _hubContext;

    public EnergyObserverSendSignalRNotification(IHubContext<NotificationHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task Handle(EnergyConsumptionExceeded notification, CancellationToken cancellationToken)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveNotification", $"Energy consumption exceeded: {notification.Consumption} > {notification.Threshold}");
    }
}