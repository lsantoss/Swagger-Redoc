using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Swagger_Redoc
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(x =>
            {
                x.IncludeXmlComments(GetXmlCommentsPath());
                x.SwaggerDoc("v1", new Info
                {
                    Title = "Swagger + Redoc",
                    Version = "v1",
                    Description = "Exemplo de projeto utlizando Swagger + Redoc",
                    //TermsOfService = "Nenhum",
                    Contact = new Contact
                    {
                        Name = "Desenvolvido por Lucas Santos",
                        Email = "l_santos@hotmail.com.br",
                        Url = "https://github.com/lsantoss"
                    }
                });
            });
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger+Redoc");
                //c.InjectStylesheet("/swagger-ui/custom.css");
                //c.InjectJavascript("/swagger-ui/custom.js");
            });

            app.UseMvc();
        }
        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\Swagger.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}