using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowDetails()
        {
            ViewData["id"] = 101;
            ViewData["firstname"] = "John";
            ViewData["lastname"] = "Smith";
            return View();
        }
    }
}
