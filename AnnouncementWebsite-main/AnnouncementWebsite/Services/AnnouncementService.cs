using AnnouncementWebsite.Data;
using AnnouncementWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnnouncementWebsite.Services
{
    public class AnnouncementService : IAnnouncementService<Announcement>
    {
        private readonly AnnouncementContext _announcementContext;
        public AnnouncementService(AnnouncementContext context)
        {
            _announcementContext = context;
        }

        public IEnumerable<Announcement> GetAllAnnouncements()
        {
            return _announcementContext.Announcements.ToList();
        }

        /// <summary>
        /// Search.
        /// </summary>
        /// <param name="titile">Input search string.</param>
        /// <returns>List of announcements.</returns>
        public IEnumerable<Announcement> SearchAnnouncements(int? number)
        {
            var announcements = _announcementContext.Announcements.AsQueryable();

            if (number != null)
            {
                announcements = announcements.Where(x => x.Number == number);
            }

            return announcements.ToList();
        }

        public Announcement GetAnnouncementById(int id)
        {
            return _announcementContext.Announcements.Find(id);
        }

        public bool SaveAnnouncement(Announcement announcement)
        {
            _announcementContext.Announcements.Add(announcement);

            return _announcementContext.SaveChanges() > 0;
        }

        public bool UpdateAnnouncement(Announcement announcement)
        {
            _announcementContext.Entry(announcement).State = EntityState.Modified;

            return _announcementContext.SaveChanges() > 0;
        }
        public bool DeleteAnnouncement(Announcement announcement)
        {
            _announcementContext.Entry(announcement).State = EntityState.Deleted;

            return _announcementContext.SaveChanges() > 0;
        }
    }
}
