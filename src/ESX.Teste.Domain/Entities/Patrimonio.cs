using System;
using System.Collections.Generic;
using System.Text;

namespace ESX.Teste.Domain.Entities
{
    public class Patrimonio
    {
        public string Nome { get; protected set; }
        public Guid MarcaId { get; protected set; }
        public string Descricao { get; protected set; }
        public Guid NumeroTombo { get; protected set; }

        public virtual Marca Marca { get; protected set; }
    }
}
