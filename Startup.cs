using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Database;
using ChatApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ChatApp
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config) => _config = config;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddMvcOptions(option => {
                option.EnableEndpointRouting = false;
            });
            /*services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(_config.GetConnectionString("DefaultConnection")));*/
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlite(_config.GetConnectionString("DefaultConnection"));
            });
            services.AddIdentity<User, IdentityRole>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 5;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseSignalR(routes => {
                
            });

            app.UseMvcWithDefaultRoute();
        }
    }
}
