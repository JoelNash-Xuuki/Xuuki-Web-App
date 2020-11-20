using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPagesCreative.Data;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
			Environment = env;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
		public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			if(Environment.IsDevelopment())
			{
				services.AddDbContext<RazorPagesCreativeContext>(options =>
        		options.UseSqlite(Configuration.GetConnectionString("RazorPagesCreativeContext")));
			}
			else
			{
				services.AddDbContext<RazorPagesCreativeContext>(options =>
            	options.UseSqlServer(
                Configuration.GetConnectionString("CreativeContext")));
			}

			services.AddRazorPages();
			
		}

		public class ApplicationDbContext : DbContext
		{
    		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
