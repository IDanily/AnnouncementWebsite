using AnnouncementWebsite.ViewModels;

namespace AnnouncementWebsite.ViewModels
{
    public class EditImageModel: UploadImageModel
    {
        public int Id { get; set; }
        public string ExistingImage { get; set; }


    }
}
