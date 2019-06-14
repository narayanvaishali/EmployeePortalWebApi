using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeePortal
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(
            options => options.AddPolicy("AllowCors",
            builder =>
            {
                builder
                //.WithOrigins("http://localhost:4456") //AllowSpecificOrigins;
                //.WithOrigins("http://localhost:4456", "http://localhost:4457") 
                //AllowMultipleOrigins;
                .AllowAnyOrigin() //AllowAllOrigins;

                //.WithMethods("GET") //AllowSpecificMethods;
                //.WithMethods("GET", "PUT") //AllowSpecificMethods;
                //.WithMethods("GET", "PUT", "POST") 
                //AllowSpecificMethods;
                // .WithMethods("GET", "PUT", "POST", "DELETE")
                //AllowSpecificMethods;
                .AllowAnyMethod() //AllowAllMethods;

                //.WithHeaders("Accept", 
                //"Content-type", "Origin", "X-Custom-Header");  
                //AllowSpecificHeaders;
                .AllowAnyHeader(); //AllowAllHeaders;
            }));
            var mvcCoreBuilder = services.AddMvcCore();

            mvcCoreBuilder
                .AddFormatterMappings()
                .AddJsonFormatters()
                .AddCors();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //app.UseCors(builder => builder
            //    .AllowAnyOrigin()
            //    .AllowAnyMethod()
            //    .AllowAnyHeader()
            //    .AllowCredentials());
            //Enable CORS policy "AllowCors"
            app.UseCors("AllowCors");
            app.UseMvc();
        }
    }
}
