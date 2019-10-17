using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using UsersAPI.Services;

namespace SASid_Code_Example
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Usually this connectionString to the database would be generated from an encrypted file, but this is just
            //      a proof of concept, and the db is only local, so that will not be necessary.
            var connectionString = "Server=localhost;Database=UsersDB;User Id=sa;Password=Passw0rd!";
            services.AddDbContext<UsersDbContext>(o => o.UseSqlServer(connectionString));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UsersDbContext usersDbContext)
        {
               if (env.IsDevelopment())
               {
                    app.UseDeveloperExceptionPage();
               }
               usersDbContext.CreateSeedData();
               app.UseStaticFiles();
               app.UseRouting();
               app.UseEndpoints(endpoints =>
               {
                    endpoints.MapControllerRoute("default", "{controller=Users}/{action=all}");
               });
          }
 
    }
}
