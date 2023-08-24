namespace AnnouncementWebsite.ViewModels
{
    public class UserActionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public bool IsAdmin { get; set; }
        public string Captcha { get; set; }
    }
}
