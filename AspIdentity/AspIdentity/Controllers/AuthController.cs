using AspIdentity.Models;
using AspIdentity.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspIdentity.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<Role> roleManager;

        public AuthController(AppDbContext context, UserManager<User> userManager, SignInManager<User> signInManager,
            RoleManager<Role> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Login", "UserName or Password InCorrect!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Some message");
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Login);
                if (user != null)
                {
                    ModelState.AddModelError("", "Already Exist");
                }
                else
                {
                    User appUser = new User
                    {
                        UserName = model.Login,
                        Email = model.Email,
                        NormalizedUserName = model.Name + " " + model.Surname
                    };
                    var result = await userManager.CreateAsync(appUser, model.Password);
                    if (result.Succeeded)
                    {
                        
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("Register", error.Description);
                        }
                    }
                }
            }

            return View(model);
        }
    }
}
