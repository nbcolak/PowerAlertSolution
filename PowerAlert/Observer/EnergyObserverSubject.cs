namespace PowerAlert.Observer;

public class EnergyObserverSubject
{
    private readonly List<IObserver> _observers = new();

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers(EnergyData data)
    {
        foreach (var observer in _observers)
        {
            observer.Update(data);
        }
    }

    public void UpdateEnergyData(EnergyData data)
    {
        if (data.Consumption > data.Threshold)
        {
            NotifyObservers(data);
        }
    }
}