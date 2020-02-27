using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Entities.DBContext;
using Firebase.Repository.Concrete;
using Firebase.Repository.Abstract;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Firebase.Services.Abstract;
using Firebase.Services.Concrete;
using AutoMapper;
using Firebase.Entities.Models;

namespace FirebaseAPI
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
            services.AddControllers();
            services.AddDbContext<FirebaseDBContext>(options => options.UseSqlServer(@"Data Source=DESKTOP-VLLFDE5\SQLEXPRESS;Initial Catalog=FirebaseDB;Integrated Security=True"));
            services.AddScoped<IBusinessService, BusinessService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee, EmployeeDTO>();
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
