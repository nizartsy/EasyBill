using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelFactory.Channel_Interfaces
{
    interface IAuthUser
    {
        object ValidateUser(object model);
        object GetAccessControlList(object model);
        object RevokePermission(object model);
        object GrantPermission(object model);
        object LockAccess(object model);
    }
}
