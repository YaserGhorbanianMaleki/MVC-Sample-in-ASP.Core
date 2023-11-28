using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevCard
{
    public class StartupDevelopment
    {
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940var envName = Configuration.GetValue("EnvName","err");
            app.Use(async (context, next) =>
            {
                context.Response.WriteAsync("its development startup");
            });
        }
    }
}
