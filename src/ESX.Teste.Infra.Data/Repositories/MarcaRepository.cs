using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Infra.Data.Context;

namespace ESX.Teste.Infra.Data.Repositories
{
    public class MarcaRepository : Repository<Marca>, IMarcaRepository
    {
        public MarcaRepository(ESXTestContext context)
            : base(context)
        {

        }
    }
}
