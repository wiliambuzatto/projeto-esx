using ESX.Teste.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESX.Teste.Application.Interfaces
{
    public interface IMarcaAppService : IDisposable
    {
        void Add(MarcaViewModel marcaviewModel);
        IEnumerable<MarcaViewModel> GetAll();
        MarcaViewModel GetById(Guid id);
        void Update(MarcaViewModel customerViewModel);
        void Remove(Guid id);
    }
}
