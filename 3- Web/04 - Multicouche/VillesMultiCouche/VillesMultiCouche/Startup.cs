using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VillesMultiCouche.Data;
using VillesMultiCouche.Data.Services;

namespace VillesMultiCouche
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
            services.AddDbContext<MyDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<VillesServices>();
            services.AddTransient<DepartementsServices>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VillesMultiCouche", Version = "v1" });
            });

            //Ajout des CORS
            services.AddCors(options =>
            {
                options.AddPolicy(name: "myPolicy",
                                    builder =>
                                    {
                                        builder.WithOrigins("*").WithMethods("GET"); ;
                                    });
                options.AddPolicy(name: "myPolicy2",
                                    builder =>
                                    {
                                        builder.WithOrigins("http://cda/").WithHeaders("content-type").WithMethods("PUT,POST,DELETE,GET");
                                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VillesMultiCouche v10"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //Utilisations des CORS par l'application
            app.UseCors("myPolicy");
            app.UseCors("myPolicy2");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
