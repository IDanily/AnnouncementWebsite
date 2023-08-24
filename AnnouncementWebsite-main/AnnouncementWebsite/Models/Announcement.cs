using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace AnnouncementWebsite.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public int? Number { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        //[Required]
        [DataType(DataType.Date)]
        [Display(Name = "Add Date")]
        public DateTime DateAdded { get; set; }
        [Required]
        [StringLength(100)]
        public int Rating { get; set; }
        //[Required]
        [DataType(DataType.Date)]
        [Display(Name = "Expiration Date")]
        public DateTime DateExpiration { get; set; }
        public User User { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string Picture { get; set; }

        public Announcement()
        {
            DateAdded = DateTime.Now;
        }
    }
}
