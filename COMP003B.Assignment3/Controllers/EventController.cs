﻿using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
    [Route("event")]
    public class EventController : Controller
    {
         [HttpGet("register/{eventCode}")]
        public IActionResult Register(string eventCode) 
        { 
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register([FromForm] EventRegistration registration)
        {
            if (!ModelState.IsValid)
            {
                return View(registration);
            }
            return RedirectToAction("Success");
        }
        [Route("success")]
        public IActionResult Success()
        { 
        return View();
        }
    }
}
