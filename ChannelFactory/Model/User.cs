using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelFactory.Model
{
    class User
    {
        public long UserID { get; set; }
        public string Username { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string E_mail { get; set; }
        public string ID_Proof { get; set; }
        public string Phone { get; set; }
        public string Alt_Phone { get; set; }
        public AccessControl.AccessList Access { get; set; }
    }
}
