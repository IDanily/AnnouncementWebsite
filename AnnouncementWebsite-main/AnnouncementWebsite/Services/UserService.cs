using AnnouncementWebsite.Data;
using AnnouncementWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace AnnouncementWebsite.Services
{
    public class UserService : IUserService<User>
    {
        private readonly AnnouncementContext _announcementContext;
        public UserService(AnnouncementContext context)
        {
            _announcementContext = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _announcementContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _announcementContext.Users.Find(id);
        }

        public bool SaveUser(User user)
        {
            _announcementContext.Users.Add(user);

            return _announcementContext.SaveChanges() > 0;
        }

        public bool UpdateUser(User user)
        {
            _announcementContext.Entry(user).State = EntityState.Modified;

            return _announcementContext.SaveChanges() > 0;
        }

        public bool DeleteUser(User user)
        {
            _announcementContext.Entry(user).State = EntityState.Deleted;

            return _announcementContext.SaveChanges() > 0;
        }
    }
}
