using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;

namespace MyHelloClientNoProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<MyHelloService.IHello> cf = new ChannelFactory<MyHelloService.IHello>("MyClientConfig");


            var defaultCred = cf.Endpoint.EndpointBehaviors.OfType<ClientCredentials>();

            ClientCredentials myCred = defaultCred.First();
            myCred.UserName.UserName = "Gert Jan";
            myCred.UserName.Password = "password";
            
            MyHelloService.IHello proxy = cf.CreateChannel();
            Console.WriteLine(proxy.Hello("Gert Jan!!"));
            ((ICommunicationObject)proxy).Close();
        }
    }
}
