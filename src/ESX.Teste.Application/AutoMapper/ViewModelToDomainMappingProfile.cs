using AutoMapper;
using ESX.Teste.Application.ViewModels;
using ESX.Teste.Domain.Entities;

namespace ESX.Teste.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MarcaViewModel, Marca>();
        }
    }
}
