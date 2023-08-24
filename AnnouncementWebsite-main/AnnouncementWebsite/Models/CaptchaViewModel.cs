using System.ComponentModel.DataAnnotations;

namespace AnnouncementWebsite.Models
{
    public class CaptchaViewModel
    {
        [Required]
        public string Captcha { get; set; }
    }
}
