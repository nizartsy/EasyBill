using IChannelFactory.Model;

namespace IChannelFactory.Interfaces
{
   public interface IResponseHandler
    {
       public ResponseContext GetResponse(); 
       public ResponseContext GetResponse(object model);
    }
}
