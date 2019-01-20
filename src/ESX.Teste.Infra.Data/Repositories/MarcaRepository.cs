using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESX.Teste.Infra.Data.Repositories
{
    public class MarcaRepository : Repository<Marca>, IMarcaRepository
    {
        public MarcaRepository(ESXTestContext context)
            : base(context)
        {

        }

        public Task<List<Marca>> List()
        {
            var list = Db.Set<Marca>().AsNoTracking().ToList();
            return Task.FromResult(list);
        }
    }
}
