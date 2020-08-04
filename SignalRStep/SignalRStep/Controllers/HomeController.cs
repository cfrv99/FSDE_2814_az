using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRStep.Hubs;
using SignalRStep.Models;

namespace SignalRStep.Controllers
{
    public class HomeController : Controller
    {   
        private readonly IHubContext<ChatHub> hubContext;

        public HomeController(IHubContext<ChatHub> hubContext)
        {
            this.hubContext = hubContext;
        }
        public IActionResult Index()
        {

            var a = ChatHub.ConnectedAdmins;
            ////////////////////
            ///
            hubContext.Clients.All.SendAsync("AdminMessage", ".............");
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
