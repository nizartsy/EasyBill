using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelFactory.Channel_Interfaces
{
    interface ILogin
    {
        object ValidateUser(object model);
    }
}
