using EmployeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{

    public class Startup
    {
        private IConfiguration _configuration;

        // Notice we are using Dependency Injection here
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application,
        // visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(
            options => options.UseSqlServer(_configuration.GetConnectionString("EmployeeDBConnection")));

            services.AddMvc(options => options.EnableEndpointRouting = false).AddXmlSerializerFormatters();

            /*
                We want the instance of the SQLEmployeeRepository class to be alive and
                available through the entire scope of a given HTTP request.
                When a new HTTP request arrives at our application we want another new instance of this class
                to be created and we want that instance also to be alive and
                available throughout the entire scope of that HTTP request,
                that's the reason we're using add scoped method to register our service in addition to add scope.
            */
            services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure
        // the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

//Testing
/*
*/
