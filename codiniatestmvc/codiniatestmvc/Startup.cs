using codiniatestmvc.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Glimpse.AspNet.Tab;

namespace codiniatestmvc
{
    public class Startup
    {
        public string ConnectionString { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("CodiniaDb");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<context>(options => options.UseSqlServer(ConnectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {








            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
       name: "blogdetails",
       pattern: "blogs/{blog_url}",
       defaults: new { controller = "Blogs", action = "SingleBlog" });
                endpoints.MapControllerRoute(
       name: "about",
       pattern: "about",
       defaults: new { controller = "Home", action = "About" });
                endpoints.MapControllerRoute(
       name: "service",
       pattern: "services",
       defaults: new { controller = "Home", action = "Services" });
                endpoints.MapControllerRoute(
       name: "forwhyus",
       pattern: "whyus",
       defaults: new { controller = "Home", action = "whyus" });
                endpoints.MapControllerRoute(
       name: "forcontactus",
       pattern: "contactus",
       defaults: new { controller = "Home", action = "contactus" });
                endpoints.MapControllerRoute(
      name: "forblog",
      pattern: "blog",
      defaults: new { controller = "Blogs", action = "Blog" });



                //SingleBlog {{ Blogs /< blog_url >}}



            });
        

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "For-Blogs",
            //        pattern: "Blogs/{blog_url}",
            //        defaults: new { controller = "Blogs", action = "SingleBlog" });
            //});

        }

        
    }
}
