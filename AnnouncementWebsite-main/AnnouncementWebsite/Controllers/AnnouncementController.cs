using AnnouncementWebsite.Data;
using AnnouncementWebsite.Models;
using AnnouncementWebsite.Services;
using AnnouncementWebsite.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using Xceed.Wpf.Toolkit;

namespace AnnouncementWebsite.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService<Announcement> _dataRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly AnnouncementContext _context;
        public AnnouncementController(IAnnouncementService<Announcement> dataRepository, IWebHostEnvironment webHostEnvironment, AnnouncementContext context)
        {
            _dataRepository = dataRepository;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        public ActionResult Index(int? searchTerm)
        {
            var model = new AnnouncementsListingModel
            {
                Number = searchTerm,
                Announcements = _dataRepository.SearchAnnouncements(searchTerm)
            };

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AnnouncementActionModel model)
        {
            var json = new JsonResult(new { });
            bool result = false;
            if (ModelState.IsValid)
            {
                //Была бы авторизация то подставляли проверку авторизованного пользователя
                var user4Count = _context.Users.Where(_ => _.Id == 4).Select(_ => _.Count).FirstOrDefault();
                var entityCount = _context.Announcements.Where(_ => _.User.Id == 4).Count();
                if (entityCount < user4Count)
                {
                    string uniqueFileName = ProcessUploadedFile(model);
                    Announcement announcement = new Announcement
                    {
                        Number = model.Number,
                        Description = model.Description,
                        Rating = model.Rating,
                        DateExpiration = model.DateExpiration,
                        Picture = uniqueFileName
                    };
                    result = _dataRepository.SaveAnnouncement(announcement);

                    return RedirectToAction(nameof(Index));
                }

                json.Value = new { Success = false, Message = "Limited publications" };

                return json;
            }

            return View(model);
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
        public ActionResult Action(AnnouncementActionModel model)
        {
            bool result = false;
            // Trying to edit an announcement
            if (model.Id > 0)
            {
                var announcement = _dataRepository.GetAnnouncementById(model.Id);
                announcement.Number = model.Number;
                announcement.Description = model.Description;
                announcement.Rating = model.Rating;
                announcement.DateExpiration = model.DateExpiration;

                if (model.Picture != null)
                {
                    if (model.ExistingImage != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, FileLocation.FileUploadFolder, model.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    announcement.Picture = ProcessUploadedFile(model);
                }
                result = _dataRepository.UpdateAnnouncement(announcement);

                model = null;

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = new AnnouncementActionModel();

            var announcement = _dataRepository.GetAnnouncementById(id);
            model.Id = announcement.Id;

            return PartialView("_Delete", model);
        }

        [HttpPost]
        public ActionResult Delete(AnnouncementActionModel model)
        {
            var announcement = _dataRepository.GetAnnouncementById(model.Id);
            var result = _dataRepository.DeleteAnnouncement(announcement);

            return RedirectToAction(nameof(Index));
        }

        private string ProcessUploadedFile(AnnouncementActionModel entity)
        {
            string uniqueFileName = null;

            if (entity.Picture != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, FileLocation.FileUploadFolder);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + entity.Picture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    entity.Picture.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}

