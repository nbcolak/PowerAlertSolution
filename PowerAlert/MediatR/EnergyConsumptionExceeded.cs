using MediatR;

namespace PowerAlert.MediatR;


public class EnergyConsumptionExceeded : INotification
{
    public double Consumption { get; }
    public double Threshold { get; }

    public EnergyConsumptionExceeded(double consumption, double threshold)
    {
        Consumption = consumption;
        Threshold = threshold;
    }
}