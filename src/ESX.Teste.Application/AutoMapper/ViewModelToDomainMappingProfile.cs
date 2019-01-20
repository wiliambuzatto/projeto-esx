using AutoMapper;
using ESX.Teste.Application.ViewModels.Marca;
using ESX.Teste.Domain.Entities;

namespace ESX.Teste.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MarcaResponseViewModel, Marca>();
            CreateMap<MarcaRequestViewModel, Marca>();
        }
    }
}
