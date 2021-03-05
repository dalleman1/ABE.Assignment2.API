using ABE.Assignment2.DomainLogic.DTO_s;
using ABE.Assignment2.DomainLogic.Querys;
using ABE.Assignment2.DomainLogic.Repository;
using ABE.Assignment2.DomainLogic.Schemas;
using ABE.Assignment2.DomainLogic.Service;
using ABE.Assignment2.DomainLogic.Types;
using GraphiQl;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;

namespace ABE.Assignment2.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Repositories:
            services.AddSingleton<ITeacherRepository, TeacherRepository>();

            //Services:
            services.AddSingleton<ITeacherService, TeacherService>();

            //Types:
            services.AddSingleton<TeacherType>();

            //Queries:
            services.AddSingleton<TeacherQuery>();

            //DTO's
            services.AddSingleton<GraphQLQueryDTO>();

            //Schemas
            services.AddSingleton<ISchema, TeacherSchema>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseGraphiQl("/teachers");
        }
    }
}
