using Microsoft.AspNetCore.Mvc;
using System;

namespace Asp.net_intro.Controllers
{
    public class CalculateController : Controller
    {
        
        public IActionResult Index()
        {
            int a = 0;
            int b = 1;
            int[] numsFib = new int[10];
            numsFib[0] = a;
            numsFib[1] = b;
            for (int i = 2; i < 10; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                numsFib[i] = c;
            }
            return View(numsFib);

        }
    }
}
