using System;
using System.Collections.Generic;
using System.Text;

namespace IChannelFactory.Model
{
   public class ResponseContext
    {
        public bool IsSucess { get; set; }
        public int AffectedRows { get; set; }
        public string ResponseData { get; set; }
        public string[] ResponseDataArray { get; set; }
        public object ResponseObject { get; set; }
        public List<object> ResponseObjectCollection { get; set; } = new List<object>();
        public Dictionary<string, object> ResponseObjectKeyCollection { get; set; } = new Dictionary<string, object>();
    }
}
