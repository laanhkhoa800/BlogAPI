using GUI_BLOG.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GUI_BLOG.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Email, string Password, string RememberMe)
        {
            bool remember = false;
         /*   if (rememberMe == "on")
                remember = true;
*/
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email , Email),
                    new Claim(ClaimTypes.Name, Email),
                    new Claim(ClaimTypes.Role, "user"),
                };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
 
            var principal = new ClaimsPrincipal(identity);
     
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
            {
                IsPersistent = remember
            });

            Response.StatusCode = 200;
            return RedirectToAction("Index", "Account");
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult RegisterUser()
        {
            return View();
        }
        [Authorize]
        public IActionResult DetailPost(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult DetaiAccount()
        {
            ViewBag.EmaiAccount = User.Identity.Name;
            return View();
        }

        public IActionResult AddNewPost()
        {
            return View();
        }
        public IActionResult MyPost()
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
