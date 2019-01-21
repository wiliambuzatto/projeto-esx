using ESX.Teste.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ESX.Teste.Domain.Interfaces.Services
{
    public interface IMarcaService : IServiceBase<Marca>
    {
        Task<List<Marca>> List();
        Task<bool> IsUp();
    } 
}
