using Microsoft.AspNetCore.Mvc;

namespace SorcererCoderNet.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View("Courses");
        }
    }
}
