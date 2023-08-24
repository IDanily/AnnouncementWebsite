using System.Collections.Generic;

namespace AnnouncementWebsite.Services
{
    public interface IUserService<TUser>
    {
        IEnumerable<TUser> GetAllUsers();
        TUser GetUserById(int id);
        bool SaveUser(TUser user);
        bool UpdateUser(TUser user);
        bool DeleteUser(TUser user);
    }
}
