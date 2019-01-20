using System.Linq;
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
    }
}
