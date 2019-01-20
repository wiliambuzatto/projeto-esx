using System;

namespace ESX.Teste.Application.ViewModels.Patrimonio
{
    public class PatrimonioResponseViewModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Guid MarcaId { get; set; }

        public int NumeroTombo { get; set; }
    }
}
