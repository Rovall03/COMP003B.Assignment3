﻿using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
