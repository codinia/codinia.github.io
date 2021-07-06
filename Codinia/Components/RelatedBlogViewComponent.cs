using Codinia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Codinia.ViewComponents
{
    public class RelatedBlogViewComponent : ViewComponent
    {
        private readonly CodiniaContext _dbcontext;
        public RelatedBlogViewComponent(CodiniaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IViewComponentResult Invoke(string category)
        {
            var blogpost = _dbcontext.BlogPost.Where(o => o.Category.Equals(category)).Take(3).ToList();
            return View(blogpost);
        }
    }
}
