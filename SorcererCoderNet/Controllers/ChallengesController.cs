using Microsoft.AspNetCore.Mvc;
using SorcererCoderNet.Models;

namespace SorcererCoderNet.Controllers
{
    public class ChallengesController : Controller
    {
        private readonly IChallenge challenge;
        public ChallengesController(IChallenge challenge) { 
            this.challenge = challenge;
        }

        public IActionResult Index()
        {
            IEnumerable<Challenge> model = challenge.GetAll();
            return View(model); // Returns Challenges.cshtml view
        }
    }
}
