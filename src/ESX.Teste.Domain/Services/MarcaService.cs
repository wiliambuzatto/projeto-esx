using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces;
using ESX.Teste.Domain.Interfaces.Services;

namespace ESX.Teste.Domain.Services
{
    public class MarcaService : ServiceBase<Marca>, IMarcaService
    {
        private readonly IMarcaRepository _repository;

        public MarcaService(IMarcaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Task<List<Marca>> List()
        {
            return _repository.List();
        }
    }
}
