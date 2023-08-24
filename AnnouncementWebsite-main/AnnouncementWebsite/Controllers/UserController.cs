using AnnouncementWebsite.Data;
using AnnouncementWebsite.Services;
using AnnouncementWebsite.ViewModels;
using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using User = AnnouncementWebsite.Models.User;

namespace AnnouncementWebsite.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService<User> _dataRepository;
        private readonly AnnouncementContext _context;
        private readonly ICaptchaValidator _captchaValidator;
        public UserController(IUserService<User> dataRepository, AnnouncementContext context, ICaptchaValidator captchaValidator)
        {
            _dataRepository = dataRepository;
            _context = context;
            _captchaValidator = captchaValidator;
        }

        public ActionResult Index()
        {
            var model = new UsersListingModel
            {
                Users = _dataRepository.GetAllUsers()
            };

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAsync(UserActionModel model)
        {
            bool result = false;
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Name = model.Name,
                    Admin = model.IsAdmin,
                    Count = model.Count
                };
                result = _dataRepository.SaveUser(user);
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult ActionUser(int? id)
        {
            var model = new UserActionModel();

            if (id.HasValue)
            {
                var user = _dataRepository.GetUserById(id.Value);

                model.Id = user.Id;
                model.Name = user.Name;
                model.IsAdmin = user.Admin;
                model.Count = user.Count;

            }

            return PartialView("_ActionUser", model);
        }

        /// <summary>
        /// Action for edit or create an user.
        /// </summary>
        /// <param name="model">Input data about user.</param>
        /// <returns>Result is json that creates or modifies model.</returns>
        [HttpPost]
        public ActionResult ActionUser(UserActionModel model)
        {
            bool result = false;

            if (model.Id > 0)
            {
                var user = _dataRepository.GetUserById(model.Id);

                model.Id = user.Id;
                model.Name = user.Name;
                model.IsAdmin = user.Admin;
                model.Count = user.Count;

                result = _dataRepository.UpdateUser(user);

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            var model = new UserActionModel();

            var user = _dataRepository.GetUserById(id);
            model.Id = user.Id;

            return PartialView("_DeleteUser", model);
        }

        [HttpPost]
        public ActionResult DeleteUser(UserActionModel model)
        {
            var json = new JsonResult(new { });

            var user = _dataRepository.GetUserById(model.Id);
            var result = _dataRepository.DeleteUser(user);

            return RedirectToAction(nameof(Index));
        }
    }
}
