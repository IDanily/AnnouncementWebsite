using System.Collections.Generic;

namespace AnnouncementWebsite.Services
{
    public interface IAnnouncementService<TAnnouncement>
    {
        IEnumerable<TAnnouncement> GetAllAnnouncements();
        IEnumerable<TAnnouncement> SearchAnnouncements(int? number);
        TAnnouncement GetAnnouncementById(int id);
        bool SaveAnnouncement(TAnnouncement announcement);
        bool UpdateAnnouncement(TAnnouncement announcement);
        bool DeleteAnnouncement(TAnnouncement announcement);
    }
}
