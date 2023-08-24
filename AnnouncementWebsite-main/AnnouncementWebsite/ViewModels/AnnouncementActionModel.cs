using AnnouncementWebsite.Models;
using Microsoft.AspNetCore.Http;
using System;

namespace AnnouncementWebsite.ViewModels
{
    public class AnnouncementActionModel : EditImageModel
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int Rating { get; set; }
        public DateTime DateExpiration { get; set; }

        public AnnouncementActionModel()
        {
            DateAdded = DateTime.Now;
        }
    }
}
