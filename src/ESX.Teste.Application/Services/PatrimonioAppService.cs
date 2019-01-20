using AutoMapper;
using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.ViewModels.Patrimonio;
using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESX.Teste.Application.Services
{
    public class PatrimonioAppService : IPatrimonioAppService
    {
        private readonly IPatrimonioService _patrimonioService;
        private readonly IMapper _mapper;

        public PatrimonioAppService(IMapper mapper,
                               IPatrimonioService patrimonioService)
        {
            _mapper = mapper;
            _patrimonioService = patrimonioService;
        }

        public PatrimonioResponseViewModel Add(PatrimonioRequestAddViewModel patrimonioViewModel)
        {
            var patrimonio = _mapper.Map<Patrimonio>(patrimonioViewModel);
            patrimonio.NumeroTombo = Guid.NewGuid().GetHashCode();
            _patrimonioService.Add(patrimonio);

            return _mapper.Map<PatrimonioResponseViewModel>(patrimonio);
        }

        public IEnumerable<PatrimonioResponseViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PatrimonioResponseViewModel>>(_patrimonioService.GetAll());
        }

        public PatrimonioResponseViewModel GetById(Guid id)
        {
            return _mapper.Map<PatrimonioResponseViewModel>(_patrimonioService.GetById(id));
        }

        public IEnumerable<PatrimonioResponseViewModel> GetByMarcaId(Guid id)
        {
            return _mapper.Map<IEnumerable<PatrimonioResponseViewModel>>(_patrimonioService.GetByMarcaId(id));
        }

        public void Remove(Guid id)
        {
            _patrimonioService.Remove(id);
        }

        public PatrimonioResponseViewModel Update(Guid id, PatrimonioRequestUpdateViewModel viewmodel)
        {
            var existingPatrimonio = _patrimonioService.GetById(id);
            var patrimonio = _mapper.Map(viewmodel, existingPatrimonio);

            _patrimonioService.Update(patrimonio);
            return _mapper.Map<PatrimonioResponseViewModel>(patrimonio);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
