using IChannelFactory.Interfaces;
using IChannelFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IChannelFactory.Factory
{
    public class LoginFactory : ILogin
    {
        public LoginFactory()
        {

        }

        public ResponseContext ValidateUser(User model)
        {
            if (model.Username == "joe" && model.Password == "123")
            {
                return new ResponseContext() { IsSucess = true, ResponseObject = new User() };
            }

            return new ResponseContext() { IsSucess = false, ResponseData = "User Validation failed" };
        }
    }
}
