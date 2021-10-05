using codiniatestmvc.Data;
using codiniatestmvc.Models;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codiniatestmvc.Controllers
{
    public class Blogs : Controller
    {

        context _context1;
        public Blogs(context context1)
        {
            _context1 = context1;
        }
        [Route("Blog")]
        public IActionResult Blog()
        {
           
            var ABC = _context1.Blogs.ToList();
            return View(ABC);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var cats = _context1.Categories.ToList();
            Blog blog = new Blog();
            blog.categoriesCollection = cats;
            //viewbags cats

            return View(blog);
        }
        [Route("Blogs/{blog_url}")]

        public async Task<IActionResult> SingleBlog(string blog_url)
        {
           

            if (blog_url == null)
            {
                return RedirectToAction("Blog");
            }
            else
            {
                var blogdetails = _context1.Blogs
                       .Where(p => p.blog_url == blog_url)
                       .Select(p => p).FirstOrDefault();
                ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

                ViewBag.MetaKeywords = blogdetails.BlogPost_Tags;
                ViewBag.MetaDescription = blogdetails.Blog_Description;
                ViewBag.Title = blogdetails.Blog_Title;
                return View(blogdetails);
            }
           

        }
        [HttpPost]
        public IActionResult Create(Blog objek)
        {
            //byte[] bytes = Convert.FromBase64String(objek.Blog_Image);
            if (objek.blogimagefile.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    objek.blogimagefile.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    objek.Blog_Image = "data:image/png;base64,"+ Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                }
            }

            //static void main (string[] args)
            //{
            //    Urlhelper urlhelper = new Urlhelper();
            //    var blog_url = urlhelper.GenerateSeoFriendlyURL("Create SEO friendly URL in C#");
            //    Console.WriteLine(blog_url);
            //    Console.Read();
            //}

            string cleanString = objek.Blog_Title.ToLower().Replace(" ", "-");
            cleanString = Regex.Replace(cleanString, @"[^a-zA-Z0-9\/_|+ -]", "");
            //Regex RegExp = new Regex(objek.Blog_Title.ToLower().Replace(" ", "-").Trim(), RegexOptions.IgnoreCase);

            //objek.Blog_Title.ToLower().Replace("", "-");


            objek.blog_url =cleanString;

            

            _context1.Blogs.Add(objek);
            _context1.SaveChanges();
            return RedirectToAction("Blog");
        }
    }
}
