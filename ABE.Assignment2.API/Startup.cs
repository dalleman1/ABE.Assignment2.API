using ABE.Assignment2.DomainLogic.DTO_s;
using ABE.Assignment2.DomainLogic.Querys;
using ABE.Assignment2.DomainLogic.Repository;
using ABE.Assignment2.DomainLogic.Schemas;
using ABE.Assignment2.DomainLogic.Service;
using ABE.Assignment2.DomainLogic.Types;
using GraphiQl;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
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
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            //Services:
            services.AddScoped<ITeacherService, TeacherService>();

            //Types:
            services.AddScoped<TeacherType>();

            //Queries:
            services.AddScoped<TeacherQuery>();

            //DTO's
            services.AddScoped<GraphQLQueryDTO>();

            //Schemas
            services.AddScoped<ISchema, TeacherSchema>();
            services.AddGraphQL()
                .AddSystemTextJson()
                .AddGraphTypes(typeof(TeacherSchema), ServiceLifetime.Scoped);
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            // app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            app.UseGraphiQl("/graphiql", "/teachers");
            app.UseGraphQL<TeacherSchema>("/teachers");

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });*/
        }
    }
}
