using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(List<ToDo> names)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            var uploads = Path.Combine(hostingEnvironment.WebRootPath + "/uploads");
            var fileName = Guid.NewGuid().ToString() + file.FileName.ToString();
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), uploads, fileName);

            file.CopyTo(new FileStream(filePath, FileMode.OpenOrCreate));



            return View();
        }

        [HttpPost]
        public IActionResult Register()

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
