using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Projeto.Application.Contracts;
using Projeto.Application.Mappings;
using Projeto.Application.Services;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Services;
using Projeto.Infra.Data.Context;
using Projeto.Infra.Data.Repositories;
using Swashbuckle.AspNetCore.Swagger;

namespace Projeto.Presentation
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
            //mapeamento da injeção de dependência
            services.AddDbContext<DataContext>(options
                => options.UseSqlServer(Configuration.GetConnectionString("Banco_dados")));

            //mapeamento das demais interfaces / classes
            
            //camada Application
            services.AddTransient<IClienteAppService, ClienteAppService>();
            services.AddTransient<IProdutoAppService, ProdutoAppService>();

            //camada Domain
            services.AddTransient<IClienteDomainService, ClienteDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();

            //Infra.Data
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            AutoMapperConfig.Register();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //configuração para gerar a documentação do Swagger
            //configurando o Swagger
            services.AddSwaggerGen(
                swagger =>
                {
                    swagger.SwaggerDoc("v1",
                        new Info
                        {
                            Title = "Desenvolvimento de Aplicação WebAPI",
                            Description = "Projeto desenvolvido para a Tecnotime utilizando as tecnologias C# WebApi, Angular, EntityFramework Core, Bootstrap, Injeção de dependência e Padrão DDD",
                            Version = "",
                            Contact = new Contact
                            {
                                Name = "Tecnotime",
                                Email = "contato@tecnotime.net.br",
                                Url = "http://tecnotime.net.br"
                            }
                        });
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger(); //ativiando o swagger
            app.UseSwaggerUI(s => { s.SwaggerEndpoint("/swagger/v1/swagger.json", ""); });
        }
    }
}