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
using WebAPI.Managers;
using WebAPI.Services;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200",
                                                          "https://localhost4201",
                                                          "http://localhost:5000",
                                                          "https://localhost:5001").AllowAnyHeader();
                                  });
            });

            services.AddControllers();
            services.AddScoped<ITekstManager, TekstManager>();
            services.AddSingleton<ITekstRepository, TekstRepository>();
            services.AddScoped<IVerzekeringenManager, VerzekeringenManager>();
            services.AddSingleton<IVerzekeringenRepository, VerzekeringenRepository>();
            services.AddScoped<IHelpMijKiezenManager, HelpMijKiezenManager>();
            services.AddSingleton<IHelpMijKiezenRepository, HelpMijKiezenRepository>();
            services.AddScoped<ITandVerzekeringManager, TandVerzekeringManager>();
            services.AddSingleton<ITandVerzekeringRepository, TandVerzekeringRepository>();
            services.AddScoped<IAanvullendeVerzekeringManager, AanvullendeVerzekeringManager>();
            services.AddSingleton<IAanvullendeVerzekeringRepository, AanvullendeVerzekeringRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
