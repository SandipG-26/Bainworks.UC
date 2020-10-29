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
        private readonly IConfigurationRoot _configroot;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            this._configroot = builder.Build();
        }

      
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //services.AddTransient<IServiceServices, ServiceServices>();
            //services.AddTransient<IAreaService, AreaService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<UCcontext>();
            services.AddTransient<IRepository<Customer>, Repository<Customer>>();
            //services.AddDbContext<UCcontext>(Configuration _configroot);
            //services.AddTransient<IRepository<Service>, Repository<Service>>();
            //services.AddTransient<IRepository<Area>, Repository<Area>>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
