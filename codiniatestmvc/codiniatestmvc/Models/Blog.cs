using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace codiniatestmvc.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Blog_Title { get; set; }
        public string Blog_Image { get; set; }
        public string blog_url { get; set; }
        [NotMapped]
        public IFormFile blogimagefile { get; set; }
        public string blog_Content { get; set; }
        public string Author_Name { get; set; }
        public string Author_Link { get; set; }
        public string BlogPost_Tags { get; set; }
        public string Blog_Description { get; set; }
        
        public int CategoryID { get; set; }
        [NotMapped]
        public List<Category> categoriesCollection { get; set; }
    }
}
