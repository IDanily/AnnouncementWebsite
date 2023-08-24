using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AnnouncementWebsite.ViewModels
{
    public class UploadImageModel
    {
        [Required]
        [Display(Name = "Picture")]
        public IFormFile Picture { get; set; }

    }
}
