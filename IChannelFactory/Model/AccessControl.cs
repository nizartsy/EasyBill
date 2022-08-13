using System;
using System.Collections.Generic;
using System.Text;

namespace IChannelFactory.Model
{
   public class AccessControl
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
