using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechSquad.Application.Controllers
{
    public class LoginController : Controller
    {
       
        public LoginController()
        {

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }
    }
}
