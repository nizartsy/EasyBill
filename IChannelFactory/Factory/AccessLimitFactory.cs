
using IChannelFactory.Interfaces;
using IChannelFactory.Model;
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
        
        public ResponseContext GetAccessControlList(User model)
        {
            throw new NotImplementedException();
        }

        public ResponseContext GrantPermission(User model)
        {
            throw new NotImplementedException();
        }

        public ResponseContext LockAccess(User model)
        {
            throw new NotImplementedException();
        }

        public ResponseContext RevokePermission(User model)
        {
            throw new NotImplementedException();
        }

        public ResponseContext ValidateUser(User model)
        {
            throw new NotImplementedException();
        }
    }
}
