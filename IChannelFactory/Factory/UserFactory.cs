using IChannelFactory.Interfaces;
using IChannelFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IChannelFactory.Factory
{
   public class UserFactory : IUser
    {
        public UserFactory()
        {

        }
        
        public User AddUser(User model)
        {
            throw new NotImplementedException();
        }


        public User DeleteUser(User model)
        {
            throw new NotImplementedException();
        }

        public User GetUserDetails(User model)
        {
            throw new NotImplementedException();
        }

        public User LockUser(User model)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User model)
        {
            throw new NotImplementedException();
        }
    }
}
