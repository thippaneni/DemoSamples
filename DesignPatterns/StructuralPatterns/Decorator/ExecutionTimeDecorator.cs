using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Decorator
{    
    public class ExecutionTimeDecorator(IHotelService service) : HotelServiceDecorator(service)
    {
        public override void CreateHotel(string hotelName)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            _service.CreateHotel(hotelName);
            stopwatch.Stop();
            Console.WriteLine($"Execution time for creating hotel '{hotelName}': {stopwatch.ElapsedMilliseconds} ms");
        }
    }

    public abstract class HotelServiceDecorator(IHotelService service) : IHotelService
    {
        protected readonly IHotelService _service = service;
        public abstract void CreateHotel(string hotelName);
    }

    public interface IHotelService
    {
        void CreateHotel(string hotelName);
    }

    public class HotelService : IHotelService
    {
        public void CreateHotel(string hotelName)
        {            
            Console.WriteLine($"Creating hotel with Name {hotelName}");
            Thread.Sleep(5000);
            Console.WriteLine($"Created hotel with Name {hotelName}");
        }
    }

}
