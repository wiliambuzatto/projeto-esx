using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using ESX.Teste.Infra.Data.Context;

namespace ESX.Teste.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Infra - Data
            services.AddScoped<ESXTestContext>();
        }
    }
}
