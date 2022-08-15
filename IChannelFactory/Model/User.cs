using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace IChannelFactory.Model
{
   public class User
    {
        public User()
        {
            UserID = 123;
            Password = "123";
            Username = "joe";
            FName = "Jhone";
            LName = "Doe";
            MName = "J";
            Address = "17 Cross, 4 Avenue, Blore 67589";
            E_mail = "joedoe@gmail.com";
            ID_Proof = "1234 567 456";
            Phone = "+91 -9645642006";
            Alt_Phone = "+91-7908167371";
            AccessRole = AccessControl.AccessRole.SuperVisor;
        }
        public long UserID { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string E_mail { get; set; }
        public string ID_Proof { get; set; }
        public string Phone { get; set; }
        public string Alt_Phone { get; set; }
        public AccessControl.AccessRole AccessRole { get; set; }
    }
}
