using IChannelFactory.Model;

namespace IChannelFactory.Interfaces
{
   public interface IUser
    {
        User AddUser(User model);
        User DeleteUser(User model);
        User UpdateUser(User model);
        User GetUserDetails(User model);
        User LockUser(User model);
    }
}
