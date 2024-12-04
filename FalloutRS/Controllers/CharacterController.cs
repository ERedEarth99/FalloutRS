using FalloutRS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FalloutRS.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ILogger<CharacterController> _logger;

        public CharacterController(ILogger<CharacterController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
