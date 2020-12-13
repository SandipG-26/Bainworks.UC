using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brainworks.UC.Persistance;
using Brainworks.UC.Services;
using Brainworks.UC.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;

namespace Brainworks.UC.API
{
    public class Startup
    {
        private readonly string _alloworigin = "_alloworigin";
        private readonly IConfigurationRoot _configroot;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            //this._configroot = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(
                options =>
                {
                    options.AddPolicy(_alloworigin, builder =>
                   {
                       builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowedToAllowWildcardSubdomains();
                   });
                });
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); 
            services.AddControllers();
            services.AddTransientServices();
            services.AddDbContext<UCcontext>();
            services.AddAutoMapper();
            //services.AddScoped<IRepository<Service>, Repository<Service>>();
            //services.AddScoped<IRepository<Customer>, Repository<Customer>>();
            //services.AddScoped<IRepository<Area>, Repository<Area>>();
            //services.AddScoped<IRepository<Vendor>, Repository<Vendor>>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(_alloworigin);
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
