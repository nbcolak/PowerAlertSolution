using Microsoft.AspNetCore.SignalR.Client;

var connection = new HubConnectionBuilder()
    .WithUrl("http://localhost:5138/notificationHub")
    .Build();

connection.On<string>("ReceiveNotification", (string message) =>
{
    Console.WriteLine($"Notification received: {message}");
});

await connection.StartAsync();
Console.WriteLine("SignalR connected.");

while (true)
{
    await Task.Delay(100);
}