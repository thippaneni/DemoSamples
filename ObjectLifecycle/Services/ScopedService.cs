namespace ObjectLifecycle.Services
{
    public class ScopedService
    {
        public Guid Id { get; } = Guid.NewGuid();

        public ScopedService()
        {
            Console.WriteLine($"Scoped object created with Id : {Id}");
        }
    }
}
