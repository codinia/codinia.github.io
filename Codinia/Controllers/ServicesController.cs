using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codinia.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult WebDevelopment()
        {
            return View();
        }
        public IActionResult DigitalMarketing()
        {
            return View();
        }
        public IActionResult MobileApps()
        {
            return View();
        }
        public IActionResult SeoConsultancy()
        {
            return View();
        }
        public IActionResult GraphicDesign()
        {
            return View();
        }
        public IActionResult WebCrawling()
        {
            return View();
        }
    }
}
