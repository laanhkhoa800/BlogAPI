using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GUI_BLOG.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult LoginAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginAdmin(string Email, string Password, string RememberMe)
        {
            bool remember = false;
            /*   if (rememberMe == "on")
                   remember = true;
   */
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email , Email),
                    new Claim(ClaimTypes.Name, Email),
                    new Claim(ClaimTypes.Role, "admin"),
                };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
            {
                IsPersistent = remember
            });

            Response.StatusCode = 200;
            return RedirectToAction("HomePageAdmin", "Admin");
        }
        [Authorize(Roles = "admin")]
        public IActionResult HomePageAdmin()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        public IActionResult GetAllUser()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        public IActionResult CreatePost()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        public IActionResult CreateUser()
        {
            return View();
        }
    }
}
