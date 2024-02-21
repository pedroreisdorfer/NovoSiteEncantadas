using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QRCoder;
using WebEncantadas.Data;
using Microsoft.EntityFrameworkCore;
using WebEncantadas.Models.Contracts.Contexts;
using Microsoft.AspNetCore.Http;
using WebEncantadas.Helper;
using WebEncantadas.Models.Contracts.Services;
using WebEncantadas.Business.ServiceLogin;
using WebEncantadas.Data.ReservaIngresso.Abstractions;
using WebEncantadas.Data.ReservaIngresso;
using WebEncantadas.Business.ServiceReserva.Abstracts;
using WebEncantadas.Business.ServiceReserva;

namespace WebEncantadas
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
            services.AddControllersWithViews();
            services.AddDbContext<Contexto>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSingleton<IConnectionManager, ConnectionManager>(); // NECESSÁRIO PARA ACESSO A NOSSA CONEXÃO COM BANCO DE DADOS. Singleton é pq a instancia é feita apenas uma vez
            services.AddSingleton<IContextData, ContextDataSqlServer>();
            services.AddScoped<IUsuarioService, LoginService>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
            services.AddScoped<IReservaService, ReservaService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // é usado no processo de Sessa, mantendo meu usuário logado

            services.AddScoped<ISessao, Sessao>(); // quando for chamado meu ISessao, será chamado meu Sessao

            services.AddSession(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });
            //Este método é usado para registrar o serviço de sessão na coleção de serviços do ASP.NET Core. Ele permite que sua aplicação utilize sessões para armazenar dados temporários associados a um usuário específico.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession(); // para habilitar as sessões dentro do projeto

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute( // aqui defino o rotiamento padrão que vou iniciar minha aplicação
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
