using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Infra.Data.Context;

namespace ESX.Teste.Infra.Data.Repositories
{
    public class PatrimonioRepository : Repository<Patrimonio>, IPatrimonioRepository
    {
        public PatrimonioRepository(ESXTestContext context)
            : base(context)
        {

        }
    }
}
