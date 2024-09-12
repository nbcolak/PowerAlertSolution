using MediatR;

namespace PowerAlert.MediatR;


public class EnergyObserverWriteToConsole : INotificationHandler<EnergyConsumptionExceeded>
{
    public Task Handle(EnergyConsumptionExceeded notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Energy consumption exceeded! Consumption: {notification.Consumption}, Threshold: {notification.Threshold}");
        return Task.CompletedTask;
    }
}