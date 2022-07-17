using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuoraForPucit.Models;
using Microsoft.Data.SqlClient;

namespace QuoraForPucit.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(User u)
        {
            if (ModelState.IsValid)
            {
                bool check = UserRepository.IsUsernamenotUnique(u.Username);
                if (check == true)
                {
                    return View("DeniedSignUp");
                }
                else
                {
                    UserRepository.AddUser(u);
                    return View("MainPage");
                }
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
            //return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ViewResult SignIn(string username, string password)
        {

            bool check = UserRepository.CheckCredentials(username, password);
            if (check == true)
            {
                return View("MainPage");
            }
            else
            {
                return View("DeniedLogin");
            }
        }
        [Route("/User/MainPage", Name = "usermainpage")]
        public ViewResult MainPage()
        {
            return View();
        }
        [Route("/User/AboutUs", Name = "aboutuss")]
        public ViewResult AboutUs()
        {
            return View();
        }
        [Route("/User/ContactUs", Name = "contactuss")]
        public ViewResult ContactUs()
        {
            return View();
        }
        public ViewResult AskQuestion()
        {
            return View();
        }
        public ViewResult Profile()
        {
            return View();
        }
    }
}
