using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using ESX.Teste.Infra.Data.Context;
using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.Services;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Infra.Data.Repositories;
using ESX.Teste.Domain.Services;
using ESX.Teste.Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.EntityFrameworkCore;

namespace ESX.Teste.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Application
            services.AddScoped<IMarcaAppService, MarcaAppService>();
            services.AddScoped<IPatrimonioAppService, PatrimonioAppService>();

            // Domain
            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<IPatrimonioService, PatrimonioService>();

            // Infra - Data
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IPatrimonioRepository, PatrimonioRepository>();
            //services.AddScoped<ESXTestContext>();


            services.AddDbContext<ESXTestContext>(config =>
            {
                string connection = Environment.GetEnvironmentVariable("ConnectionString") ?? configuration.GetConnectionString("DefaultConnection");
                config.UseSqlServer(connection);
            });
        }
    }
}
