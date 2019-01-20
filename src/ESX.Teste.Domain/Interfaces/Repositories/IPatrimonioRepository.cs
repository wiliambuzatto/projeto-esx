using ESX.Teste.Domain.Entities;
using System;
using System.Linq;

namespace ESX.Teste.Domain.Interfaces
{
    public interface IPatrimonioRepository : IRepository<Patrimonio>
    {
        IQueryable<Patrimonio> GetByMarcaId(Guid marcaid);
    }
}
