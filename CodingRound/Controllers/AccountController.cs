using CodingRound.Models;
using CodingRound.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingRound.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserServices services;

        public AccountController(IUserServices services)
        {
            this.services = services;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            try
            {
                var res=services.Registration(user);
                if (res >= 1)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ViewBag.Error = "Something went wrong !";
                    return View("Create");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Create");
            }
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User User)
        {
            try
            {
                var res = services.Login(User);

                    HttpContext.Session.SetInt32("UserId", res.UserId);
                
                if (res != null)
                {
                    return RedirectToAction("Index", "Feedback");
                }
                else
                {
                    ViewBag.Error = "Check mail id or password !";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Create");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
