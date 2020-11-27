using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost myHost = new ServiceHost(typeof(MyHelloService.HelloService)))
            {
                myHost.Open();
                Console.WriteLine("Service has started. Press ENTER to shutdown!");
                Console.ReadLine();
            }
        }
    }
}
