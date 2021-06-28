using Codinia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net.Mail;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace Codinia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INotyfService _notyf;
        public HomeController(ILogger<HomeController> logger, INotyfService notyf)
        {
            _logger = logger;
            _notyf = notyf;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
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
        [HttpPost]
        public IActionResult ContactUs(FormModel form)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    string subject = "A new message has received from "  + form.name;
                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new System.Net.NetworkCredential
                    ("junkiedunkie.ab@gmail.com", "MyNameIsGroot067");
                    smtp.Send("codiniateam@gmail.com", form.email, subject, form.message);
                    smtp.Send(form.email, "info@codinia.com", "noreply", "Hi " + form.name + " ,\nWe have received your query , we will get back to you on this email as soon as possible. \n Regards , \nTeam Codinia");
                }
                _notyf.Success("Success Notification");
            }
            catch (Exception ex)
            {
                _notyf.Error("Something went wrong");
            }
            return Redirect("/");
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
