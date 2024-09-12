namespace PowerAlert.Observer;

public class EnergyObserverWriteToConsole : IObserver
{
    public void Update(EnergyData data)
    {
        Console.WriteLine($"Energy consumption exceeded! Consumption: {data.Consumption}, Threshold: {data.Threshold}");
    }
}