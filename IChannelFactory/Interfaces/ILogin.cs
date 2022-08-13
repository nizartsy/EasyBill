using IChannelFactory.Model;

namespace IChannelFactory.Interfaces
{
    public interface ILogin
    {
        ResponseContext ValidateUser(User model);
    }
}
