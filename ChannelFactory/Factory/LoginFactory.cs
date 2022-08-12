using ChannelFactory.Channel_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelFactory.Factory
{
    class LoginFactory : ILogin
    {
        public LoginFactory()
        {

        }
        
        public object ValidateUser(object model)
        {
            throw new NotImplementedException();
        }
    }
}
