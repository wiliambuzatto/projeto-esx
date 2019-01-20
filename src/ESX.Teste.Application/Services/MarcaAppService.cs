using AutoMapper;
using AutoMapper.QueryableExtensions;
using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.ViewModels.Marca;
using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ESX.Teste.Application.Services
{
    public class MarcaAppService : IMarcaAppService
    {
        private readonly IMarcaService _marcaService;
        private readonly IMapper _mapper;

        public MarcaAppService(IMapper mapper,
                               IMarcaService marcaService)
        {
            _mapper = mapper;
            _marcaService = marcaService;
        }

        public MarcaResponseViewModel Add(MarcaRequestViewModel marcaviewModel)
        {
            var marca = _mapper.Map<Marca>(marcaviewModel);
            _marcaService.Add(marca);

            return _mapper.Map<MarcaResponseViewModel>(marca);
        }

        public IEnumerable<MarcaResponseViewModel> GetAll()
        {
            return _marcaService.GetAll().ProjectTo<MarcaResponseViewModel>();
        }

        public MarcaResponseViewModel GetById(Guid id)
        {
            return _mapper.Map<MarcaResponseViewModel>(_marcaService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _marcaService.Remove(id);
        }

        public MarcaResponseViewModel Update(MarcaRequestViewModel customerViewModel)
        {
            var marca = _mapper.Map<Marca>(customerViewModel);
            _marcaService.Update(marca);

            return _mapper.Map<MarcaResponseViewModel>(marca);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
