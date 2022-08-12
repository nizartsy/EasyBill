using ChannelFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelFactory.Channel_Interfaces
{
    interface IUser
    {
        User AddUser(User model);
        User DeleteUser(User model);
        User UpdateUser(User model);
        User GetUserDetails(User model);
        User LockUser(User model);
    }
}
