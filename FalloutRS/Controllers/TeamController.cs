﻿using Microsoft.AspNetCore.Mvc;

namespace FalloutRS.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
