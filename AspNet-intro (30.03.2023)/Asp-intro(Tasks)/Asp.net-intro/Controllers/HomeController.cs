using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace Asp.net_intro.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { };
  
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    Array.Resize(ref nums, nums.Length + 1);
                    nums[nums.Length - 1] = i;

                }
            }
            return View(nums);
        }


    }
}
