using System;
using System.Linq;
using System.Threading.Tasks;
using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Domain.Interfaces.Services;

namespace ESX.Teste.Domain.Services
{
    public class PatrimonioService : ServiceBase<Patrimonio>, IPatrimonioService
    {
        private readonly IPatrimonioRepository _repository;

        public PatrimonioService(IPatrimonioRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IQueryable<Patrimonio> GetByMarcaId(Guid marcaid)
        {
            return _repository.GetByMarcaId(marcaid);
        }

        public Task<bool> IsUp()
        {
            return _repository.IsUp();
        }
    }
}
