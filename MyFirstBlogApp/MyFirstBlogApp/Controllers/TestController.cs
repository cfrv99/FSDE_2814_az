using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MyFirstBlogApp.DTOs.Request;
using MyFirstBlogApp.Filters;

namespace MyFirstBlogApp.Controllers
{
    public class TestController : Controller
    {
        //automapper


        public IActionResult Index()
        {
            return View(new TestModel());
        }
        //@mit.az
        [HttpPost]
        [ModelStateFilter]
        public IActionResult Index(TestModel model)
        {
            

            return RedirectToAction("Index", "Home");

            //if (string.IsNullOrEmpty(model.Name))
            //{
            //    ModelState.AddModelError(nameof(model.Name), "Name bosh ola bilmez!!!!");
            //}
            //if (string.IsNullOrEmpty(model.Surname))
            //{
            //    ModelState.AddModelError(nameof(model.Surname), "Surname bosh ola bilmez!!!!");
            //}
            //if (string.IsNullOrEmpty(model.Email))
            //{
            //    ModelState.AddModelError(nameof(model.Email), "Email bosh ola bilmez!!!!");

            //}
            //else
            //{
            //    if (!model.Email.Contains("@"))
            //    {
            //        ModelState.AddModelError(nameof(model.Email), "Bele email olur ala ?");

            //    }
            //}

            return View(model);
        }
    }
}