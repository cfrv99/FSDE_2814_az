using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCAuth.Filters;
using MVCAuth.Models;
using MVCAuth.Services;

namespace MVCAuth.Controllers
{
    [TestActionFilter(Message = "Test message")]
    public class HomeController : Controller
    {
        private readonly IUserManager userManager;

        public HomeController(IUserManager userManager)
        {
            this.userManager = userManager;
        }
        [AuthorizeFilter, CustomExFilter]
        public IActionResult Index()
        {
            throw new Exception("Salam");

        }

        [AuthorizeFilter]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
