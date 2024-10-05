using BEPWay.Interfaces;
using BEPWay.Models;
using BEPWay.Models.Domain;
using BEPWay.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BEPWay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository repo;

        public HomeController(ILogger<HomeController> logger, IUserRepository repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Why()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Login(UserDTO user)
        {
            User userModel = new User
            {
                //UserName = user.UserName,
                //FatherName = user.FatherName,
                //CNIC = user.CNIC,
                //Password = user.Password,
                //Name = user.Name,
                //DateOfBirth = user.DateOfBirth,
                //Email = user.Email,
                //MobileNo = user.MobileNo,
            };
            var userDTO = repo.AddAsync(userModel);
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}