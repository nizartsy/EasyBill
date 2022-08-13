
using IChannelFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IChannelFactory.Factory
{
    class AccessLimitFactory : IAuthUser
    {
        public AccessLimitFactory()
        {

        }
        
        public object GetAccessControlList(object model)
        {
            throw new NotImplementedException();
        }

        public object GrantPermission(object model)
        {
            throw new NotImplementedException();
        }

        public object LockAccess(object model)
        {
            throw new NotImplementedException();
        }

        public object RevokePermission(object model)
        {
            throw new NotImplementedException();
        }

        public object ValidateUser(object model)
        {
            throw new NotImplementedException();
        }
    }
}
