using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codinia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View("Blog");
        }
        public IActionResult EightTips()
        {
            return View();
        }
        public IActionResult ElevenTips()
        {
            return View();
        }
        public IActionResult BlogPost()
        {
            return View();
        }
        public IActionResult TenTips()
        {
            return View();
        }
    }
}
