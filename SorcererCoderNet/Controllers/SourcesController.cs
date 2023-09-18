using Microsoft.AspNetCore.Mvc;

namespace SorcererCoderNet.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            return View("Sources"); // Return sources view 
        }
    }
}
