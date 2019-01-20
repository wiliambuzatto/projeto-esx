using System;

namespace ESX.Teste.Domain.Entities
{
    public class Marca : EntityBase<Marca>
    {
        private Marca() { }

        public Marca(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}
