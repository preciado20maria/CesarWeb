using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CesarWeb.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CesarWeb
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
            services.AddMvc();

            /// Cada vez que alguien necesite ISeguridadService<int> en el constructor
            /// se le dará un SeguridadService
            /// Esto se llama Depency Injection
            services.AddTransient<ISeguridadService<int>,SeguridadService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {


            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            /// La ruta por defecto cambio a /Home/Encriptar
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Encriptar}/{id?}");
            });
        }
    }
}
