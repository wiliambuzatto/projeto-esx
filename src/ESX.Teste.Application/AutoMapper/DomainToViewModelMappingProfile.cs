using AutoMapper;
using ESX.Teste.Application.ViewModels.Marca;
using ESX.Teste.Domain.Entities;

namespace ESX.Teste.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Marca, MarcaRequestViewModel>();
            CreateMap<Marca, MarcaResponseViewModel>();
        }
    }
}
