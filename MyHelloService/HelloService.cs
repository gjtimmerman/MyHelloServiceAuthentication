using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Text;

namespace MyHelloService
{
    public class HelloService : IHello
    {
        public string Hello(string prompt)
        {
            string retvalue;
            retvalue = string.Format("Hello: {0}", prompt);
            Console.WriteLine(retvalue);
            return retvalue;
        }

    }
    public class MyPasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == "Gert Jan" && password == "password")
                return;
            else
                throw new SecurityTokenException("UserName/Password incorrect");
        }
    }
}
