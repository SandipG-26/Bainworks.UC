using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Brainworks.UC.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var hostBuilder = CreateHostBuilder(args);
            //var host = hostBuilder.Build();
            //host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder =>
        //    {
        //        builder.UseStartup<Startup>();
        //    });
        //}
    }
}
