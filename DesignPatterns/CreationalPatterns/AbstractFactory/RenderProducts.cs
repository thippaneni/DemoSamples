using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class RenderProducts(IDeviceFactory deviceFactory)
    {
        private readonly IProduct _product = deviceFactory.ShowPrice();

        public void ShowPrice()
        {            
            _product.Price();
        }
    }

    public interface IProduct
    {
        void Price();
    }    

    public class AndroidDevice : IProduct
    {
        public void Price() => Console.WriteLine("Price in Android Device - 10/- INR");
    }

    public class MacDevice : IProduct
    {
        public void Price() => Console.WriteLine("Price in Mac Device - 20/- INR");
    }

    public interface IDeviceFactory
    {
        IProduct ShowPrice();
    }

    public class AndroidDeviceFactory : IDeviceFactory
    {
        public IProduct ShowPrice() => new AndroidDevice();        
    }

    public class MacDeviceFactory : IDeviceFactory
    {
        public IProduct ShowPrice() => new MacDevice();
    }
}
