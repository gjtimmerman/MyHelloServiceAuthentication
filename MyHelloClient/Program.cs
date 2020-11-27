using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHelloClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClient.HelloClient proxy = new MyClient.HelloClient();
            proxy.ClientCredentials.UserName.UserName = "Gert Jan";
            proxy.ClientCredentials.UserName.Password = "password";
            Console.WriteLine(proxy.Hello("Gert Jan"));
            proxy.Close();
        }
    }
}
