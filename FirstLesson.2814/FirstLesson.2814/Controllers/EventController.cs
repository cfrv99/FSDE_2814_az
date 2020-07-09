using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson._2814.Controllers
{

    // /event/index/{id?}
    /*
     1.Route
     2.QueryString
     3.ModelBinding
         */
    public class EventController : Controller
    {
        public string Index(int id)
        {
            return $"Hello World + {id}";
        }
        // /event/invtationForm
        [HttpGet]
        public IActionResult InvitationForm()
        {
            var path = HttpContext.Request.Path.Value.ToString();
            return View();
        }


        /*
         1.Oz adinda view axtaracaq
         2.View nun daxilindki parametre baxacaq
         3.View daxilinde parametr yoxdusa ve ya oz adinda her hansi view yoxdusa gedib hansi get daxilinde cagirilirsa onu getirecek
             */
        [HttpPost]
        public IActionResult SubmitInvitation(string name,string surname,bool isComming)
        {
            ViewBag.IsComming = isComming;
            ViewBag.Name = name;
            ViewBag.Surname = surname;
            var path = HttpContext.Request.Path.Value.ToString();
            return View("Thanks");
            //return RedirectToAction("Error", new { url = name });
        }
        public IActionResult Error(string url)
        {
            ViewBag.ErrorMessage = url;
            return View();
        }
        public IActionResult NewAction()
        {
            return View();
        }

    }
}
