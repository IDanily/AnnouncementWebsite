using System;
using System.Collections.Generic;
using AnnouncementWebsite.Models;

namespace AnnouncementWebsite.ViewModels
{
    public class AnnouncementsListingModel
    {
        public IEnumerable<Announcement> Announcements { get; set; }
        public int? Number { get; set; }

        public string Discription { get; set; }
        public int Rating { get; set; }
        public DateTime DateExpiration { get; set; }
    }
}
