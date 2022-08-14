using System;
using System.Collections.Generic;
using System.Text;

namespace IChannelFactory.Model
{
   public class AccessControl
    {

        public enum AccessRole
        {
            SuperVisor,
            Manager,
            Teller,
            Administrator
        }

        public enum AccessOperation
        {
            Grant,
            Revoke,
            Temp
        }
    }
}
