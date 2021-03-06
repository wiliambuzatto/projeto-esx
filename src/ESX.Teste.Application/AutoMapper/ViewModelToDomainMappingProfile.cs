﻿using AutoMapper;
using ESX.Teste.Application.ViewModels.Marca;
using ESX.Teste.Application.ViewModels.Patrimonio;
using ESX.Teste.Domain.Entities;

namespace ESX.Teste.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MarcaResponseViewModel, Marca>();
            CreateMap<MarcaRequestViewModel, Marca>();
            CreateMap<MarcaUpdateViewModel, Marca>();

            CreateMap<PatrimonioRequestAddViewModel, Patrimonio>();
            CreateMap<PatrimonioRequestUpdateViewModel, Patrimonio>();

            CreateMap<Patrimonio, Patrimonio>()
              .ForMember(x => x.NumeroTombo, opt => opt.Ignore());
        }
    }
}
