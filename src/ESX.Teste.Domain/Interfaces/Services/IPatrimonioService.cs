using ESX.Teste.Domain.Entities;
using System;
using System.Linq;

namespace ESX.Teste.Domain.Interfaces.Services
{
    public interface IPatrimonioService : IServiceBase<Patrimonio>
    {
        IQueryable<Patrimonio> GetByMarcaId(Guid marcaid);
    }
}
