namespace ObjectLifecycle.Services
{
    public class TransientService
    {
        public Guid Id { get; } = Guid.NewGuid();

        public TransientService()
        {
            Console.WriteLine($"Transient object created with Id : {Id}");
        }
    }
}
