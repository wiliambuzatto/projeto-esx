using ESX.Teste.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ESX.Teste.Domain.Interfaces
{
    public interface IMarcaRepository : IRepository<Marca>
    {
        Task<List<Marca>> List();
    }
}
