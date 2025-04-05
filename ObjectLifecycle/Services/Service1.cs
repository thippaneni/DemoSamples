namespace ObjectLifecycle.Services
{
    public class Service1(ScopedService scopedService)
    {
        public Guid Id { get; } = scopedService.Id;
        public void Print()
        {
            Console.WriteLine($"Service1: {scopedService.Id}");
        }   
    }
}
