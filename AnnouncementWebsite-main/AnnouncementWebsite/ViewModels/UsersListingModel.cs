using System;
using System.Collections.Generic;
using AnnouncementWebsite.Models;

namespace AnnouncementWebsite.ViewModels
{
    public class UsersListingModel
    {
        public IEnumerable<User> Users { get; set; }
        public string Name { get; set; }

        public bool Admin { get; set; }
    }
}
