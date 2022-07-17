using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings;

namespace StudentManagementSystem.Controllers
{
    public class AuthenticationController: Controller
    {
        //GET: /Authentication
        public IActionResult Index()
        {
            return View();
        }

        //GET: /Authentication/Welcome
        public IActionResult Welcome(string name, int numTimes)
        {
            //return "This is my welcome action method";
            return View();
        }

        //GET: /Authentication/Login
        public IActionResult Login()
        {
            return View();
        }
        //GET: /Authentication/Register
        public IActionResult Register()
        {
            return View();
        }
    }
}

