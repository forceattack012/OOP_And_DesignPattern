using Proxy.Proxy;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerProxy customerProxy = new CustomerProxy();
            customerProxy.GetCustomer();

            Console.WriteLine("Hello World!");
        }
    }
}
