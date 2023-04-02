using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { 1, 4, 7, 8, 9, 0, 3 };
            return View(nums);
        }

        //public string Index(int id)
        //{
        //    if(id == 0)
        //    {
        //        return "Aqshin";
        //    }
        //    return "Aqshin - " + id;
        //}


        //public string Detail(string slug,string name)
        //{
        //    return slug + " " + name;
        //}


        //private string GetName()
        //{
        //    return "Aqshin";
        //}
    }

    
}
