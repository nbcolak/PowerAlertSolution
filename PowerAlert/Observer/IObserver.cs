namespace PowerAlert.Observer;

public interface IObserver
{
    void Update(EnergyData data);
}