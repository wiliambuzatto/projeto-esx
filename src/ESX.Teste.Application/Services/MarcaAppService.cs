using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ESX.Teste.Application.Interfaces;
using ESX.Teste.Application.ViewModels;
using ESX.Teste.Domain.Entities;
using ESX.Teste.Domain.Interfaces;

namespace ESX.Teste.Application.Services
{
    public class MarcaAppService : IMarcaAppService
    {
        private readonly IMarcaRepository _marcaRepository;
        private readonly IMapper _mapper;

        public MarcaAppService(IMapper mapper,
                               IMarcaRepository marcaRepository)
        {
            _mapper = mapper;
            _marcaRepository = marcaRepository;
        }

        public void Add(MarcaViewModel marcaviewModel)
        {
            var marca = _mapper.Map<Marca>(marcaviewModel);
            _marcaRepository.Add(marca);
        }

        public IEnumerable<MarcaViewModel> GetAll()
        {
            return _marcaRepository.GetAll().ProjectTo<MarcaViewModel>();
        }

        public MarcaViewModel GetById(Guid id)
        {
            return _mapper.Map<MarcaViewModel>(_marcaRepository.GetById(id));
        }

        public void Remove(Guid id)
        {
            _marcaRepository.Remove(id);
        }

        public void Update(MarcaViewModel customerViewModel)
        {
            var marca = _mapper.Map<Marca>(customerViewModel);
            _marcaRepository.Update(marca);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
