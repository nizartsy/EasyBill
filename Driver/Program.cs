using System;
using IChannelFactory;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            IChannelFactory.Interfaces.ILogin login = new IChannelFactory.Factory.LoginFactory();
            IChannelFactory.Model.User user = new IChannelFactory.Model.User() { UserID = 123, Password = "123" };
            var res = login.ValidateUser(user);
            if (res.IsSucess==true)
            {
                Console.WriteLine((res.ResponseObject as IChannelFactory.Model.User).UserID.ToString());
            }
        }
    }
}
