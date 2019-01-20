using ESX.Teste.Application.ViewModels.Patrimonio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESX.Teste.Application.Interfaces
{
    public interface IPatrimonioAppService : IDisposable
    {
        PatrimonioResponseViewModel Add(PatrimonioRequestAddViewModel patrimonioViewModel);
        IEnumerable<PatrimonioResponseViewModel> GetAll();
        PatrimonioResponseViewModel GetById(Guid id);
        PatrimonioResponseViewModel Update(Guid id, PatrimonioRequestUpdateViewModel marcaviewModel);
        void Remove(Guid id);
    }
}
