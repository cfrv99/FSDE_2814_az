using FSDE_2814SecondAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDE_2814SecondAsp.Controllers
{
    public class EventController : Controller
    {
        public EventController()
        {

        }
        [HttpGet]
        public IActionResult InvitationForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(Person model)
        {
            ViewBag.IsComming = model.IsComming;
            ViewBag.Name = model.FirstName;
            ViewBag.Surname = model.Surname;
            ViewBag.Person = model;
            ViewData["Ibrahim"] = "Salam Ibrahim";

            return View("Thanks");
        }
        [Route("/details")]
        public IActionResult Details()  // /event/details
        {
            var url = HttpContext.Request.Path.Value.ToString();
            TempData["Error"] = "Sende error var";
            return RedirectToAction("Error", new { Url = url });
        }

        public IActionResult Error(string Url)
        {
            ViewBag.Url = Url;
            return View();
        }
        [HttpGet]
        public IActionResult ForAddForm()
        {
            Person person = new Person
            {
                FirstName = "Murad"
            };
            Student student = new Student
            {
                Age = 17
            };
            AddViewModel model = new AddViewModel
            {
                Person = person,
                Student = student
            };

            List<AddViewModel> modelList = new List<AddViewModel>
            {
                new AddViewModel
            {
                Person = person,
                Student = student
            },
                 new AddViewModel
            {
                Person = person,
                Student = student
            },
                  new AddViewModel
            {
                Person = person,
                Student = student
            }
        };
            return View(modelList);
        }

        [HttpPost]
        public IActionResult Add(string name)
        {
            TempData["Message"] = name;
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {

            return View();
        }

        public IActionResult PartialTest()
        {
            return View();
        }
    }
}
