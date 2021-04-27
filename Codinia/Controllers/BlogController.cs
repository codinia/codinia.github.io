using Codinia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codinia.Controllers
{
    public class BlogController : Controller
    {
        private readonly CodiniaContext _dbContext;
        public BlogController (CodiniaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Blog()
        {
            var blogPost = _dbContext.BlogPost
                .ToList();
            return View(blogPost);
        }
        public IActionResult EightTips()
        {
            return View();
        }
        public IActionResult ElevenTips()
        {
            return View();
        }
        public IActionResult BlogPost(string blogurl)
        {
            var blogpost = _dbContext.BlogPost.FirstOrDefault(o => o.PostURL == blogurl);
            return View(blogpost);
        }
        public IActionResult TenTips()
        {
            return View();
        }
    }
}
