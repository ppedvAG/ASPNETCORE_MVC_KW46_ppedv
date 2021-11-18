using DependencyInversionSample;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_DI_Samples
{
    public class Startup
    {
        public Startup(IConfiguration configuration) //ServiceProvider.GetRequiredService -> IConfiguration ist hier verfügbar 
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } //komplette appsetting.json liegt im Arbeitsspeicher vor

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Hier wird die ServiceCollection befüllt
            services.AddControllersWithViews(); //MVC Pattern in servicecollection gelegt + weitere Feature die mit MVC zusammenarbeiten 

            //services.AddRazorPages(); //Raozr-Page Framework

            //services.AddMvc(); //AddControllersWithViews + AddRazorPages


            services.AddSingleton<ICar, MockCar>();
        }
        ////Hier wird folgendes passieren->  ServiceProvider provider = services.BuildServiceProvider();

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
