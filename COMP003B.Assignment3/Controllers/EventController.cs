using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{

    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register([FromRoute] string eventCode)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] EventRegistration Event)
        {
            if (!ModelState.IsValid)
            {
                return View(Event);
            }
            return RedirectToAction("Success", Event);
        }


        [Route("success")]
        public IActionResult Success(EventRegistration Event)
        {
            return View(Event);
        }
    }
}
