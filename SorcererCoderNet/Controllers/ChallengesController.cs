using Microsoft.AspNetCore.Mvc;

namespace SorcererCoderNet.Controllers
{
    public class ChallengesController : Controller
    {
        public IActionResult Index()
        {
            return View("Challenges"); // Returns Challenges.cshtml view
        }
    }
}
