using MediatR;
using Microsoft.AspNetCore.SignalR;
using PowerAlert.Observer;
using PowerAlert.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSignalR();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(Program));

builder.Services.AddSingleton<EnergyObserverSubject>(sp =>
{
    var energyObserverSubject = new EnergyObserverSubject();

    energyObserverSubject.RegisterObserver(new EnergyObserverWriteToConsole());
    energyObserverSubject.RegisterObserver(new EnergyObserverSendSignalRNotification(
        sp.GetRequiredService<IHubContext<NotificationHub>>()));

    return energyObserverSubject;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();

    endpoints.MapHub<NotificationHub>("/notificationHub");
});

app.Run();