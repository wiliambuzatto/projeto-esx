using System;

namespace ESX.Teste.Domain.Entities
{
    public class Patrimonio : EntityBase<Patrimonio>
    {
        private Patrimonio() { }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Guid MarcaId { get; set; }

        public int NumeroTombo { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
