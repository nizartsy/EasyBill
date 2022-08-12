using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelFactory.Model
{
    class AccessControl
    {
        public enum AccessList
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
