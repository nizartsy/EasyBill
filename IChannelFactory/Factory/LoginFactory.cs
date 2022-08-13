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
            if (model.UserID == 123 && model.Password == "123")
            {
                return new ResponseContext() { IsSucess = true, ResponseObject = model };
            }

            return new ResponseContext() { IsSucess = false, ResponseData = "User Validation failed" };
        }
    }
}
