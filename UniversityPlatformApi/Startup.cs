using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UniversityPlatformApi.Models;
using UniversityPlatformApi.Repository;
using UniversityPlatformApi.Repository.Interfaces;
using UniversityPlatformApi.Service;
using UniversityPlatformApi.Service.Interfaces;

namespace UniversityPlatformApi
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
            services.AddControllers();
            services.AddDbContext<UniversityPlatformDBContext>(optios => optios.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            var assembly = Assembly.Load("UniversityPlatformApi.Service");
            //Add Dependency Injection Here..
            AddDependecyToServices(services, assembly);
            services.AddScoped<IUow, Uow>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        public void AddDependecyToServices(IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && !t.IsGenericType && !t.IsNested);
            foreach (var type in types)
            {
                var iface = type.GetInterface("I" + type.Name);
                services.AddScoped(iface, type);
            }
        }
    }
}
