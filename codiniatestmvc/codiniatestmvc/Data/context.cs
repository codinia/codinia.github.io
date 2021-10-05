using codiniatestmvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codiniatestmvc.Data
{
    public class context:DbContext
    {
        public context(DbContextOptions<context> options):base (options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
