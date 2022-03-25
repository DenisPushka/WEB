using DataAccess;
using DataAccess.Models;
using Domain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(c => { c.EnableEndpointRouting = false; });
            // services.AddSingleton<IHuman, Person>();
            services.AddSingleton<ApplicationContext, ApplicationContext>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            //     services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //     services.AddReact();
            //     services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName).AddChakraCore();
            // services.AddControllers();
            services.AddMvcCore();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseMvc(b =>
                {
                    b.MapRoute(
                        "api",
                        "api/{controller}/{action}/{id?}"
                    );
                    
                    b.MapRoute(
                        "default",
                        "{controller}/{action}/{id?}",
                        new {controller = "Root", action = "Person"}
                    );
                }
            );
        }
    }
}