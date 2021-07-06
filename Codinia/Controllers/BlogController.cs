using Codinia.Models;
using Codinia.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;

namespace Codinia.Controllers
{
    public class BlogController : Controller
    {
        private readonly CodiniaContext _dbContext;
        private readonly IHostingEnvironment hostingEnvironment;
        public BlogController(CodiniaContext dbContext, IHostingEnvironment hostingEnvironment)
        {
            _dbContext = dbContext;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Blog()
        {
            var blogPost = _dbContext.BlogPost.ToList();
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
        public IActionResult StaticBlog()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBlog(CreateViewModel model)
        {
            model.PostDate = DateTime.Now;
            model.PostURL = model.PostTitle.Replace(" ", "-").ToLower();
            string vdicretory = $"assets{Path.DirectorySeparatorChar}images{Path.DirectorySeparatorChar}blog";
            string dbPath = string.Empty;
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, vdicretory);
                    uniqueFileName = Guid.NewGuid() + "_" + model.Photo.FileName;
                    string filePath =  Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                     dbPath = $"/assets/images/blog/{uniqueFileName}";
                }
            }
            BlogPost dbObj = new BlogPost();
            dbObj.AuthorName = model.AuthorName;
            dbObj.PostDate = model.PostDate;
            dbObj.PostDescription = model.PostDescription;
            dbObj.PostTitle = model.PostTitle;
            dbObj.TableOfContent = model.TableOfContent;
            dbObj.PostURL = model.PostURL;
            dbObj.PostContent = model.PostContent;
            dbObj.Category = model.Category;
            dbObj.ReadTime = model.ReadTime;
            dbObj.PostTags = model.PostTags;
            dbObj.ThumbnailImageUrl = dbPath;

            _dbContext.BlogPost.Add(dbObj);
            _dbContext.SaveChanges();
            return RedirectToAction("CreateBlog");
        }
        public IActionResult TempBlog()
        {
            return View();
        }
    }
}