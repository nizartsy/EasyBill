using IChannelFactory.Model;
namespace IChannelFactory.Interfaces
{
    public interface IAuthUser
    {
        ResponseContext ValidateUser(User model);
        ResponseContext GetAccessControlList(User model);
        ResponseContext RevokePermission(User model);
        ResponseContext GrantPermission(User model);
        ResponseContext LockAccess(User model);
    }
}
