using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codiniatestmvc.Models
{
    public class Urlhelper
    {
        public string GenerateSeoFriendlyURL(string Blog_Title)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9-\s]", (RegexOptions)0);
            Blog_Title = regex.Replace(Blog_Title, "");
            Blog_Title = Blog_Title.ToLower().Replace(" - ", "-");
            Blog_Title = Blog_Title.ToLower().Replace("- ", "-");
            Blog_Title = Blog_Title.ToLower().Replace(" -", "-");
            Blog_Title = Blog_Title.ToLower().Replace("   ", " ");
            Blog_Title = Blog_Title.ToLower().Replace("  ", " ");
            Blog_Title = Blog_Title.ToLower().Replace("  ", " ");
            Blog_Title = Blog_Title.ToLower().Replace(" ", " ");
            Blog_Title = Blog_Title.ToLower().Replace(" ", "-");
            return Blog_Title;
        }
    }
}
