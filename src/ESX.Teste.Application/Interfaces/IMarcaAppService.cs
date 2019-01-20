using ESX.Teste.Application.ViewModels.Marca;
using System;
using System.Collections.Generic;

namespace ESX.Teste.Application.Interfaces
{
    public interface IMarcaAppService : IDisposable
    {
        MarcaResponseViewModel Add(MarcaRequestViewModel marcaviewModel);
        IEnumerable<MarcaResponseViewModel> GetAll();
        MarcaResponseViewModel GetById(Guid id);
        MarcaResponseViewModel Update(Guid id, MarcaUpdateViewModel marcaviewModel);
        void Remove(Guid id);
    }
}
