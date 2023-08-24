using Microsoft.AspNetCore.Mvc;
using AnnouncementWebsite.Models;
using AnnouncementWebsite.Services;
using AnnouncementWebsite.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using AnnouncementWebsite.Data;
using System.Linq;

namespace AnnouncementWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnnouncementService<Announcement> _dataRepository;
        private readonly AnnouncementContext _context;
        public HomeController(IAnnouncementService<Announcement> dataRepository, AnnouncementContext context)
        {
            _dataRepository = dataRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            var entityList = _context.Announcements.OrderByDescending(_ => _.Rating).ToList();
            return View(entityList);
        }

        [HttpGet]
        public ActionResult Action(int? id)
        {
            var model = new AnnouncementActionModel();

            // Trying to edit an announcement
            if (id.HasValue)
            {
                var announcement = _dataRepository.GetAnnouncementById(id.Value);

                model.Id = announcement.Id;
                model.Number = announcement.Number;
                model.Description = announcement.Description;
                model.DateExpiration = announcement.DateExpiration;
                model.Rating = announcement.Rating;
                model.ExistingImage = announcement.Picture;
            }

            return PartialView("_Action", model);
        }

        /// <summary>
        /// Action for edit or create an announcement.
        /// </summary>
        /// <param name="model">Input data about announcement.</param>
        /// <returns>Result is json that creates or modifies model.</returns>
        [HttpPost]
        public JsonResult Action(AnnouncementActionModel model)
        {
            var json = new JsonResult(new { });
            bool result;

            // Trying to edit an announcement
            if (model.Id > 0)
            {
                var announcement = _dataRepository.GetAnnouncementById(model.Id);
                announcement.Number = model.Number;
                announcement.Description = model.Description;
                announcement.Rating = model.Rating;
                announcement.DateExpiration = model.DateExpiration;

                result = _dataRepository.UpdateAnnouncement(announcement);
            }
            // Trying to create an announcement
            else
            {
                var announcement = new Announcement
                {
                    Number = model.Number,
                    Description = model.Description,
                    Rating = model.Rating,
                    DateExpiration = model.DateExpiration
                };

                result = _dataRepository.SaveAnnouncement(announcement);
            }

            if (result)
            {
                json.Value = new { Success = true };
            }
            else
            {
                json.Value = new { Success = false, Message = "Unable to perform action on Announcement." };
            }

            return json;
        }
    }
}
