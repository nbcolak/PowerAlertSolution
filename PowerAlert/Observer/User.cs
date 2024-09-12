namespace PowerAlert.Observer;

public class User : IObserver
{
    private string _name;
    public User(string name)
    {
        _name = name;
    }

    public void Update(EnergyData data)
    {
        Console.WriteLine($"Notification to {_name}: Your energy consumption has exceeded the threshold! Consumption: {data.Consumption}");
    }
}