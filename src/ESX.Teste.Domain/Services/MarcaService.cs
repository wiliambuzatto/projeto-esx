using ESX.Teste.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
