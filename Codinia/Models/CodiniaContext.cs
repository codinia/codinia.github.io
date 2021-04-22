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
        {
        }
    }
}
