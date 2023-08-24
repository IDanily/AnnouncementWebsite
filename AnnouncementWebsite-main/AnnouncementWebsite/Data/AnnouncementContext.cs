using AnnouncementWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace AnnouncementWebsite.Data
{
    public class AnnouncementContext : DbContext
    {
        public AnnouncementContext(DbContextOptions<AnnouncementContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
