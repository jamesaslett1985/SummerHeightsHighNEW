using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Website
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddSession();
            services.AddMvc();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();

            app.UseHttpsRedirection();

            //EXAMPLE START
            //In this block, we can log the error and also serve a response to the user, but the page won't look like the rest of the site
            //app.UseStatusCodePages(async context =>
            //{
            //    context.HttpContext.Response.ContentType = "text/html";

            //    if (context.HttpContext.Response.StatusCode == 404)
            //    {
            //        // Log this error here, e.g. to a database. You can use the context.HttpContext.Request 
            //        // object to access important information like the requested URL
            //    }

            //    await context.HttpContext.Response.WriteAsync(
            //        "We're <b>really</b> sorry, but something went wrong. Error code: " +
            //        context.HttpContext.Response.StatusCode);
            //});
            //EXAMPLE END

            //This is a better alternative to the above. It will respond with a redirect instead of an actual message. Here, all HTTP status errors will be redirected to a method called Http on the ErrorController
            app.UseStatusCodePagesWithRedirects("/Error/Http?statusCode={0}");

            //allows static files in wwwroot to be served
            app.UseStaticFiles();
            //allow visitors to browse the wwwroot/img folder by going to https://localhost:44345/img/
            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider
   (
       Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img")
   ),
                RequestPath = "/img"
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
