using ObjectLifecycle.Services;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<TransientService>();
builder.Services.AddScoped<ScopedService>();
builder.Services.AddSingleton<SingletonService>();

builder.Services.AddScoped<Service1>();

var app = builder.Build();

app.MapGet("/", ()=> "Welcome to Object Lifecycle Api Sample");


app.MapGet("/lifetimes", (
    TransientService transient1,
    TransientService transient2,
    ScopedService scoped1,
    ScopedService scoped2,
    SingletonService singleton1,
    SingletonService singleton2,
    Service1 service1, Service1 service2) =>
{
    service1.Print();
    service2.Print();
    return new
    {
        Transient1 = transient1.Id,
        Transient2 = transient2.Id,
        Scoped1 = scoped1.Id,
        Scoped2 = scoped2.Id,
        Service1 = service1.Id,        
        Service2 = service2.Id,
        Singleton1 = singleton1.Id,
        Singleton2 = singleton2.Id
    };    
});

app.MapGet("/lifetimes1", (
    TransientService transient1,
    TransientService transient2,
    ScopedService scoped1,
    ScopedService scoped2,
    SingletonService singleton1,
    SingletonService singleton2,
    Service1 service1, Service1 service2) =>
{
    service1.Print();
    service2.Print();
    return new
    {
        Transient1 = transient1.Id,
        Transient2 = transient2.Id,
        Scoped1 = scoped1.Id,
        Scoped2 = scoped2.Id,
        Service1 = service1.Id,
        Service2 = service2.Id,
        Singleton1 = singleton1.Id,
        Singleton2 = singleton2.Id
    };
});


app.Run();
