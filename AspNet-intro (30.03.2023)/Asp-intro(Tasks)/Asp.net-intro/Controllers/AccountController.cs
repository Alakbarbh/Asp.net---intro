using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Principal;
using System;

namespace Asp.net_intro.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<string> accounts= new List<string>() {"Konul","Chinara","Roya","Eycahan","Cavid","Shaig"};
            return View(accounts);
        }
  
    }
}
