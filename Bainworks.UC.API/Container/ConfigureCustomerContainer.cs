using Microsoft.Extensions.DependencyInjection;
using Brainworks.UC.Persistance;
using Brainworks.UC.Services;
using AutoMapper;
using System;
using Brainworks.UC.Data;

namespace Brainworks.UC.API
{
    public static class ConfigureCustomerContainer
    {
        public static void AddTransientServices(this IServiceCollection services)
        {
            services.AddTransient<IServiceServices, ServiceServices>();
            services.AddTransient<IAreaService, AreaService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<UCcontext>();
            services.AddScoped<IRepository<Customer>, Repository<Customer>>();
        }
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mappingconfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new UCProfile());
            });

            IMapper mapper = mappingconfig.CreateMapper();
            services.AddSingleton(mapper);
        }


    }
}
