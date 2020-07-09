using FSDE_2814SecondAsp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDE_2814SecondAsp.Controllers
{
    public class EventController:Controller
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
            return View("Thanks");
        }
        [Route("/details")]
        public IActionResult Details()  // /event/details
        {
            var url = HttpContext.Request.Path.Value.ToString();
            return RedirectToAction("Error",new { Url = url });
        }
       
        public IActionResult Error(string Url)
        {
            ViewBag.Url = Url;
            return View();
        }
    }
}
