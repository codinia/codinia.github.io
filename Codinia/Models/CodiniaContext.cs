using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codinia.Models
{
    public class CodiniaContext : DbContext
    {
        public CodiniaContext(DbContextOptions<CodiniaContext> options) : base(options)
        { }
        public DbSet<BlogPost> BlogPost { get; set; }
    }
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        public string PostURL { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string AuthorName { get; set; }
        public string AuthorURL { get; set; }
        public string PostDescription { get; set; }
        public string PostTags { get; set; }
        public DateTime PostDate { get; set; }
        public string ThumbnailImageUrl { get; set; }
    }
}
