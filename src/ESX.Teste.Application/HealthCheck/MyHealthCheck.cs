using ESX.Teste.Domain.Interfaces.Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace ESX.Teste.Application.HealthCheck
{
    public class MyHealthCheck : IHealthCheck
    {
        private readonly IMarcaService _marcaService;
        private readonly IPatrimonioService _patrimonioService;

        public MyHealthCheck(IMarcaService marcaService,
                             IPatrimonioService patrimonioService)
        {
            _marcaService = marcaService;
            _patrimonioService = patrimonioService;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (await _marcaService.IsUp() && await _patrimonioService.IsUp())
            {
                return HealthCheckResult.Healthy();
            }
            return HealthCheckResult.Unhealthy();
        }
    }
}
