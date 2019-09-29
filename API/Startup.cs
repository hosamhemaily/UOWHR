using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models;
using Repo;
using Service;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
        }

        public IConfiguration Configuration { get; }

        private IHostingEnvironment HostingEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //services.AddIdentity<ApplicationUser,GoldhayRole>(config =>
            //{
            //    config.User.RequireUniqueEmail = true;
            //}).AddEntityFrameworkStores<HR_SystemContext>();

            services.AddIdentity<ApplicationUser, GoldhayRole>(config =>
            {
                config.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<HR_SystemContext>();

            services.AddAuthentication()
                    .AddJwtBearer(cfg =>
                    {
                        cfg.TokenValidationParameters = new TokenValidationParameters()
                        {
                            ValidIssuer = Configuration["Tokens:Issuer"],
                            ValidAudience = Configuration["Tokens:Audience"],
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:TOKEN_KEY"]))
                        };
                    });

            string connectionString = string.Empty;
            if (HostingEnvironment.IsDevelopment())
            {
                connectionString = Configuration.GetConnectionString("DefaultConnectionDev");
            }
            else
            {
                connectionString = Configuration.GetConnectionString("DefaultConnection");
            }
            

            services.AddDbContext<HR_SystemContext>(options =>
                   options.UseSqlServer(connectionString));

            services.AddDbContext<IdentityContext>(options =>
                   options.UseSqlServer(connectionString));

            //services.AddScoped<DbContext, GoldhayAdminContext>();
            services.AddScoped<IAbsenseTransactionService, AbsenceTransactionService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAdditionalPaymentTransactionService, AdditionalPaymentTransactionService>();
            services.AddScoped<ICommonProcess<AddionalPaymentHDModel>, CommonProcess<AddionalPaymentHDModel>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<AbsenceTransactionTbl>, Repository<AbsenceTransactionTbl>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {

                    context.Response.StatusCode = 500; // or another Status accordingly to Exception Type
                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null)
                    {
                        var ex = error.Error;

                        await context.Response.WriteAsync(ex.ToString(), Encoding.UTF8);


                        var sb = new StringBuilder();
                        sb.AppendLine("URL:            " + context.Request.Path);
                        sb.AppendLine("Date:           " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
                        sb.AppendLine("Error Message:  " + ex.ToString());
                        sb.AppendLine("Inner Message:  " + ex.InnerException?.ToString());
                        sb.AppendLine("----------------------------------------------------------------");

                        var fileName = Path.Combine(HostingEnvironment.WebRootPath, "logErrors.txt");
                        File.AppendAllText(fileName, sb.ToString());


                        //new ErrorDetails()
                        //{
                        //    StatusCode = 500,
                        //    Message = ex.Message // or your custom message
                        //    // other custom data
                        //}
                        //.ToString(), Encoding.UTF8);
                    }
                });
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
