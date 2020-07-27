using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstBlogApp.Entities;
using MyFirstBlogApp.Entities.Base;
using MyFirstBlogApp.Factory;
using MyFirstBlogApp.Models;

namespace MyFirstBlogApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            ClassFactory.CreateInstance(new Post());
            return View();
        }

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
