using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codinia.ViewModels
{
    public class CreateViewModel
    {
        
        public string PostURL { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string AuthorName { get; set; }
        public string AuthorURL { get; set; }
        public string PostDescription { get; set; }
        public string PostTags { get; set; }
        public DateTime PostDate { get; set; }
        public IFormFile Photo { get; set; }
        public string TableOfContent { get; set; }
        public string Category { get; set; }
        public string ReadTime { get; set; }
    }
}
