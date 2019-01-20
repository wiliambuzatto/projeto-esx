using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using ESX.Teste.Infra.Data.Context;
using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.Services;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Infra.Data.Repositories;
using ESX.Teste.Domain.Services;
using ESX.Teste.Domain.Interfaces.Services;

namespace ESX.Teste.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Application
            services.AddScoped<IMarcaAppService, MarcaAppService>();

            // Domain
            services.AddScoped<IMarcaService, MarcaService>();
            //services.AddScoped<IPatrimonioService, PatrimonionService>();

            // Infra - Data
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IPatrimonioRepository, PatrimonioRepository>();
            services.AddScoped<ESXTestContext>();
        }
    }
}
