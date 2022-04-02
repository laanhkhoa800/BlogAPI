
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Authentication.Cookies;
using DAL.Reponsitorys;
using DAL.Reponsitorys.Reponsitory;
using DAL.Reponsitorys.Interfaces;
using LOGIC.Services.Interfaces;
using LOGIC.Services.Service;
using LOGIC.IUnitOfWorks;
using DAL.Dependence.UnitOfWork;


namespace BlogCoreAPI
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
         
            /*services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(connection));*/
          
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Knowledge space API", Version = "v1" });
            });

            services.AddDbContext<ApContext>(options =>
                                                    options.UseSqlServer(
                                                        Configuration.GetConnectionString("DefaultConnection"),
                                                        b => b.MigrationsAssembly(typeof(AppContext).Assembly.FullName)));

            //identity
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie("Cookies");
            services.AddControllersWithViews();
            //Res Service
            /*            services.AddRazorPages();*/
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseReponsitotyy<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserSevice, Usersevice>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IPostCommentRepository, PostCommentRepository>();
            services.AddTransient<IPostCommentService, PostCommentService>();
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });
            services.AddHttpClient();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.WithOrigins("*")
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*   loggerFactory.AddConsole(Configuration.GetSection("Logging"));
               loggerFactory.AddDebug();*/

            
            app.UseCookiePolicy();
            app.UseHttpsRedirection();
            app.UseSession();

            app.UseAuthentication();
            app.UseRouting();
            app.UseCors();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //Set swagger test API
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Knowledge space API v1");
            });



        }
    }
}
