using System;

namespace ESX.Teste.Domain.Entities
{
    public class Patrimonio : EntityBase
    {
        public Patrimonio(Guid id, string nome, string descricao, Guid marcaId, int numeroTombo)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            MarcaId = marcaId;
            NumeroTombo = numeroTombo;
        }

        private Patrimonio() { }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Guid MarcaId { get; set; }

        public int NumeroTombo { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
