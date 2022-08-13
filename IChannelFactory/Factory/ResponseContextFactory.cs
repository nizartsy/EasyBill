using IChannelFactory.Interfaces;
using IChannelFactory.Model;

namespace IChannelFactory.Factory
{
    public class ResponseContextFactory : IResponseHandler
    {
        public ResponseContext GetResponse()
        {
            throw new System.NotImplementedException();
        }

        public ResponseContext GetResponse(object model)
        {
            throw new System.NotImplementedException();
        }
    }
}
