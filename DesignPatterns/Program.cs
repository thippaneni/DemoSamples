// See https://aka.ms/new-console-template for more information
using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.BehavioralPatterns.Observer;
using DesignPatterns.BehavioralPatterns.Strategy;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.StructuralPatterns.Facade;

Console.WriteLine("Welcome to Design Patterns Examples in .Net8");
Console.WriteLine("======================================================");

Console.WriteLine("1. Singleton Pattern");
Logger logger = Logger.Instance;
logger.Log("This is a singleton logger instance.");

Console.WriteLine("======================================================");
Console.WriteLine("2. Factory Method");

INotification notification = NotificationFactory.Create("event");
notification.Notify("Venugopal");

INotification notification2 = NotificationFactory.Create("email");
notification2.Notify("Venugopal");

Console.WriteLine("======================================================");
Console.WriteLine("3. Abstract Factory");

string GetPlatform() => "Mac";
IDeviceFactory deviceFactory = GetPlatform() switch
{
    "Android" => new AndroidDeviceFactory(),
    "Mac" => new MacDeviceFactory(),
    _ => throw new NotImplementedException()
};

RenderProducts renderProducts = new(deviceFactory);
renderProducts.ShowPrice();

Console.WriteLine("======================================================");
Console.WriteLine("4. Builder");

ReportBuilder reportBuilder = new();
reportBuilder.AddTitle("Monthly Report");
reportBuilder.AddContent("This is the content of the report.");


var report = reportBuilder.Build();
Console.WriteLine(report.Title);
Console.WriteLine(report.Content);

Console.WriteLine("======================================================");
Console.WriteLine("5. Adapter Pattern");

ModernSystem system = new();
system.Request();

Console.WriteLine("======================================================");
Console.WriteLine("6. Decorator Pattern");
IPaymentService originalService = new PaymentService();

// Wrap the original service with a decorator
IPaymentService loggedService = new LoggingDecorator(originalService);
loggedService.ProcessPayment(1500);

IHotelService hotelService = new HotelService();
IHotelService newhotelService = new ExecutionTimeDecorator(hotelService);
newhotelService.CreateHotel("New Deluxe Hotel");
Console.WriteLine("======================================================");

Console.WriteLine("7. Facade Pattern");

var orderFacade = new OrderFacade();
orderFacade.PlaceOrder("P123", "U456", "user@example.com", 2500);


Console.WriteLine("======================================================");
Console.WriteLine("8. Strategy Pattern");

var context = new PaymentStrategyContext();

context.SetStrategy(new CreditCardPayment());
context.ExecutePayment(1000);

context.SetStrategy(new UpiPayment());
context.ExecutePayment(2000);

Console.WriteLine("======================================================");
Console.WriteLine("9. Command Pattern");

var remote = new RemoteCommand();
remote.AddCommand(new LightOnCommand(new Light()));
remote.AddCommand(new FanOnCommand(new Fan()));

remote.ExecuteAll();
Console.WriteLine("======================================================");
Console.WriteLine("10. Observer Pattern");
var orderService = new OrderService();

orderService.RegisterObserver(new DesignPatterns.BehavioralPatterns.Observer.EmailNotification());
orderService.RegisterObserver(new DesignPatterns.BehavioralPatterns.Observer.SmsNotification());

orderService.PlaceOrder("ORD123");
Console.WriteLine("======================================================");
Console.ReadLine();

