﻿using AnimalFarm.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalFarm
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            var appConfiguration = Configuration.GetSection("SiteConfig").Get<SiteConfig>();
            services.AddSingleton(appConfiguration);

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStatusCodePages();
            app.UseAuthentication();

            app.UseMvc(routes=>
                routes.MapRoute("default", "{controller=Animal}/{action=Index}")
            );
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseCookiePolicy();
        }
    }
}
