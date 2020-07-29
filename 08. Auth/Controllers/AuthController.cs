using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MVCAuth.Encryptors;
using MVCAuth.Models;
using MVCAuth.Services;
using MVCAuth.ViewModels;

namespace MVCAuth.Controllers
{
    public class AuthController : Controller
    {
        private readonly UsersDbContext context;
        private readonly IUserManager userManager;

        public AuthController(UsersDbContext context, IUserManager userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(new User
                {
                    Login = model.Login,
                    PasswordHash = Sha256Encryptor.Encrypt(model.Password),
                    IsAdmin = false
                });
                await context.SaveChangesAsync();
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (userManager.Login(model.Login, model.Password))
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("all", "Incorrect username or password!");
            }
            return View();
        }
    }
}