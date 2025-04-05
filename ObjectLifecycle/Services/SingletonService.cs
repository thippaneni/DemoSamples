namespace ObjectLifecycle.Services
{
    public class SingletonService
    {
        public Guid Id { get; } = Guid.NewGuid();

        public SingletonService()
        {
            Console.WriteLine($"Singleton object created with Id : {Id}");
        }
    }
}
